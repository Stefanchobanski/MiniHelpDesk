using App.Models;
using App.Models.DTOs;
using App.Models.Enums;
using App.Repositories.interfaces;
using App.Services;

using Microsoft.Extensions.Logging.Abstractions;

using Moq;
using NUnit.Framework;

namespace NUnit_Tests
{
    public class TicketServiceTest
    {
        private TicketService _ticketService;
        private Mock<ITicketRepository> _mockRepo;

        [SetUp]
        public void Setup()
        {
            _mockRepo = new Mock<ITicketRepository>();

            _ticketService = new TicketService(
                _mockRepo.Object,
                new NullLogger<TicketService>());
        }

        [Test]

        public async Task CreateTicket_ShouldReturnCreatedTicket()
        {
            var request = new CreateTicketRequestDTO
            {
                Email = "test@example.com",
                Description = "Test description"
            };

            _mockRepo
                .Setup(r => r.AddAsync(It.IsAny<Ticket>()))
                .Returns(Task.CompletedTask);

            var result = await _ticketService.CreateTicket(request);

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Email, Is.EqualTo(request.Email));
            Assert.That(result.Description, Is.EqualTo(request.Description));
            Assert.That(result.Status, Is.EqualTo(Status.New.ToString()));

            _mockRepo.Verify(
                r => r.AddAsync(It.IsAny<Ticket>()),
                Times.Once);
        }

        [Test]

        public async Task GetTicketById_ShouldReturnTicket_WhenTicketExists()
        {
            var ticket = new Ticket
            {
                TicketId = 1,
                Email = "user@test.com",
                Description = "Broken monitor",
                Status = Status.New
            };

            _mockRepo
                .Setup(r => r.GetByIdAsync(1))
                .ReturnsAsync(ticket);

            var result = await _ticketService.GetTicketById(1);

            Assert.That(result, Is.Not.Null);
            Assert.That(result.TicketId, Is.EqualTo(1));
            Assert.That(result.Email, Is.EqualTo(ticket.Email));
        }

        [Test]

        public async Task UpdateTicketStatus_ShouldUpdateStatusSuccessfully()
        {
            var ticket = new Ticket
            {
                TicketId = 1,
                Status = Status.New
            };

            _mockRepo
                .Setup(r => r.GetByIdAsync(1))
                .ReturnsAsync(ticket);

            _mockRepo
                .Setup(r => r.UpdateAsync(It.IsAny<Ticket>()))
                .Returns(Task.CompletedTask);

            await _ticketService.UpdateTicketStatus(1, Status.Closed);

            Assert.That(ticket.Status, Is.EqualTo(Status.Closed));

            _mockRepo.Verify(
                r => r.UpdateAsync(It.IsAny<Ticket>()),
                Times.Once);
        }

        [Test]

        public void GetTicketsByEmail_ShouldReturnTickets()
        {
            var tickets = new List<Ticket>
            {
                 new Ticket
                {
                  TicketId = 1,
                  Email = "user@test.com",
                  Status = Status.New
                },
                 new Ticket
                {
                 TicketId = 2,
                 Email = "user@test.com",
                 Status = Status.Closed
                }
            };

            _mockRepo
                .Setup(r => r.GetByEmail("user@test.com"))
                .Returns(tickets);

            var result = _ticketService
                .GetTicketsByEmail("user@test.com")
                .ToList();

            Assert.That(result.Count, Is.EqualTo(2));
            Assert.That(result[0].TicketId, Is.EqualTo(1));
            Assert.That(result[1].Status, Is.EqualTo(Status.Closed.ToString()));
        }

        [Test]
        public async Task AssignTicket_ShouldAssignTechnicalSuccessfully()
        {
            var ticket = new Ticket
            {
                TicketId = 1,
                Status = Status.New
            };

            _mockRepo
                .Setup(r => r.GetByIdAsync(1))
                .ReturnsAsync(ticket);

            _mockRepo
                .Setup(r => r.UpdateAsync(It.IsAny<Ticket>()))
                .Returns(Task.CompletedTask);

            await _ticketService.AssignTicket(1, "tech@test.com");

            Assert.That(ticket.AssignedTo, Is.EqualTo("tech@test.com"));
            Assert.That(ticket.Status, Is.EqualTo(Status.InProgress));

            _mockRepo.Verify(
                r => r.UpdateAsync(It.IsAny<Ticket>()),
                Times.Once);
        }

        [Test]
        public void AssignTicket_ShouldThrowException_WhenTicketNotFound()
        {
            _mockRepo
                .Setup(r => r.GetByIdAsync(1))
                .ReturnsAsync((Ticket)null);

            Assert.ThrowsAsync<Exception>(async () =>
                await _ticketService.AssignTicket(1, "tech@test.com"));
        }

        [Test]
        public async Task DeleteTicket_ShouldDeleteSuccessfully()
        {
            var ticket = new Ticket
            {
                TicketId = 1
            };

            _mockRepo
                .Setup(r => r.GetByIdAsync(1))
                .ReturnsAsync(ticket);

            _mockRepo
                .Setup(r => r.DeleteAsync(1))
                .ReturnsAsync(true);
            await _ticketService.DeleteTicket(1);

            _mockRepo.Verify(
                r => r.DeleteAsync(1),
                Times.Once);
        }

        [Test]
        public async Task GetAllTickets_ShouldReturnAllTickets()
        {
            var tickets = new List<Ticket>
            {
                new Ticket
                {
                    TicketId = 1,
                    Email = "a@test.com",
                    Description = "Issue 1",
                    Status = Status.New
                },
                new Ticket
                {
                    TicketId = 2,
                    Email = "b@test.com",
                    Description = "Issue 2",
                    Status = Status.Closed
                }
            };

            _mockRepo
                .Setup(r => r.GetAllTickets())
                .Returns(tickets);

            var result = _ticketService
                .GetAllTickets()
                .ToList();

            Assert.That(result.Count, Is.EqualTo(2));
            Assert.That(result[0].Email, Is.EqualTo("a@test.com"));
            Assert.That(result[1].Status, Is.EqualTo(Status.Closed.ToString()));
        }

    }
}