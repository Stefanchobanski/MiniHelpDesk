using App.DTOs;
using App.Models;
using App.Repositories.interfaces;
using App.Services;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;

namespace YourApp.Tests
{
    [TestFixture]
    public class AuditLogServiceTests
    {
        private Mock<IAuditLogRepository> _repositoryMock;
        private Mock<ILogger<AuditLogService>> _loggerMock;
        private AuditLogService _service;

        [SetUp]
        public void SetUp()
        {
            _repositoryMock = new Mock<IAuditLogRepository>();
            _loggerMock = new Mock<ILogger<AuditLogService>>();
            _service = new AuditLogService(_repositoryMock.Object, _loggerMock.Object);
        }

        private static AuditLog MakeAuditLog(string id = "log-1", string ticketId = "ticket-1", string userId = "user-1") => new()
        {
            AuditLogId = id,
            Field = "status",
            OldValue = "Open",
            NewValue = "Closed",
            ChangedDate = DateTime.UtcNow,
            ChangedByUserId = userId,
            TicketId = ticketId
        };

        private static CreateAuditLogDto MakeCreateDto(string field = "status", string ticketId = "ticket-1", string userId = "user-1") => new()
        {
            Field = field,
            OldValue = "Open",
            NewValue = "Closed",
            ChangedByUserId = userId,
            TicketId = ticketId
        };

        [Test]
        public async Task GetByIdAsync_ValidId_ReturnsDto()
        {
            var log = MakeAuditLog();
            _repositoryMock.Setup(r => r.GetByIdAsync("log-1")).ReturnsAsync(log);

            var result = await _service.GetByIdAsync("log-1");

            Assert.That(result, Is.Not.Null);
            Assert.That(result!.Id, Is.EqualTo("log-1"));
            Assert.That(result.Field, Is.EqualTo("status"));
        }

        [Test]
        public async Task GetByIdAsync_NotFound_ReturnsNull()
        {
            _repositoryMock.Setup(r => r.GetByIdAsync("missing")).ReturnsAsync((AuditLog?)null);

            var result = await _service.GetByIdAsync("missing");

            Assert.That(result, Is.Null);
        }

        [Test]
        public void GetByIdAsync_EmptyId_ThrowsArgumentException()
        {
            Assert.ThrowsAsync<ArgumentException>(() => _service.GetByIdAsync(""));
        }

        [Test]
        public void GetByIdAsync_WhitespaceId_ThrowsArgumentException()
        {
            Assert.ThrowsAsync<ArgumentException>(() => _service.GetByIdAsync("   "));
        }

        [Test]
        public async Task GetByTicketIdAsync_ValidTicketId_ReturnsMappedDtos()
        {
            var logs = new List<AuditLog> { MakeAuditLog("log-1"), MakeAuditLog("log-2") };
            _repositoryMock.Setup(r => r.GetByTicketIdAsync("ticket-1")).ReturnsAsync(logs);

            var result = (await _service.GetByTicketIdAsync("ticket-1")).ToList();

            Assert.That(result.Count, Is.EqualTo(2));
            Assert.That(result[0].Id, Is.EqualTo("log-1"));
            Assert.That(result[1].Id, Is.EqualTo("log-2"));
        }

        [Test]
        public async Task GetByTicketIdAsync_NoLogs_ReturnsEmptyList()
        {
            _repositoryMock.Setup(r => r.GetByTicketIdAsync("ticket-empty")).ReturnsAsync(new List<AuditLog>());

            var result = await _service.GetByTicketIdAsync("ticket-empty");

            Assert.That(result, Is.Empty);
        }

        [Test]
        public void GetByTicketIdAsync_EmptyId_ThrowsArgumentException()
        {
            Assert.ThrowsAsync<ArgumentException>(() => _service.GetByTicketIdAsync(""));
        }

        [Test]
        public async Task GetByUserIdAsync_ValidUserId_ReturnsDtos()
        {
            var logs = new List<AuditLog> { MakeAuditLog(userId: "user-1") };
            _repositoryMock.Setup(r => r.GetByUserIdAsync("user-1")).ReturnsAsync(logs);

            var result = (await _service.GetByUserIdAsync("user-1")).ToList();

            Assert.That(result.Count, Is.EqualTo(1));
            Assert.That(result[0].ChangedByUserId, Is.EqualTo("user-1"));
        }

        [Test]
        public void GetByUserIdAsync_EmptyId_ThrowsArgumentException()
        {
            Assert.ThrowsAsync<ArgumentException>(() => _service.GetByUserIdAsync(""));
        }

        [Test]
        public async Task GetFilteredAsync_ValidFilter_ReturnsDtos()
        {
            var filter = new AuditLogFilterDto { TicketId = "ticket-1" };
            var logs = new List<AuditLog> { MakeAuditLog() };
            _repositoryMock.Setup(r => r.GetFilteredAsync(filter)).ReturnsAsync(logs);

            var result = await _service.GetFilteredAsync(filter);

            Assert.That(result.Count(), Is.EqualTo(1));
        }

        [Test]
        public void GetFilteredAsync_NullFilter_ThrowsArgumentNullException()
        {
            Assert.ThrowsAsync<ArgumentNullException>(() => _service.GetFilteredAsync(null!));
        }

        [Test]
        public void GetFilteredAsync_FromDateAfterToDate_ThrowsArgumentException()
        {
            var filter = new AuditLogFilterDto
            {
                FromDate = DateTime.UtcNow.AddDays(1),
                ToDate = DateTime.UtcNow
            };

            Assert.ThrowsAsync<ArgumentException>(() => _service.GetFilteredAsync(filter));
        }

        [Test]
        public async Task GetFilteredAsync_EqualFromAndToDate_DoesNotThrow()
        {
            var date = DateTime.UtcNow;
            var filter = new AuditLogFilterDto { FromDate = date, ToDate = date };
            _repositoryMock.Setup(r => r.GetFilteredAsync(filter)).ReturnsAsync(new List<AuditLog>());

            var result = await _service.GetFilteredAsync(filter);

            Assert.That(result, Is.Empty);
        }

        [Test]
        public async Task CreateAsync_ValidDto_ReturnsCreatedDto()
        {
            var dto = MakeCreateDto();
            var log = MakeAuditLog();
            _repositoryMock.Setup(r => r.CreateAsync(It.IsAny<AuditLog>())).ReturnsAsync(log);

            var result = await _service.CreateAsync(dto);

            Assert.That(result, Is.Not.Null);
            Assert.That(result.TicketId, Is.EqualTo("ticket-1"));
            Assert.That(result.Field, Is.EqualTo("status"));
        }

        [Test]
        public void CreateAsync_NullDto_ThrowsArgumentNullException()
        {
            Assert.ThrowsAsync<ArgumentNullException>(() => _service.CreateAsync(null!));
        }

        [Test]
        public void CreateAsync_EmptyField_ThrowsArgumentException()
        {
            var dto = MakeCreateDto(field: "");
            Assert.ThrowsAsync<ArgumentException>(() => _service.CreateAsync(dto));
        }

        [Test]
        public void CreateAsync_EmptyTicketId_ThrowsArgumentException()
        {
            var dto = MakeCreateDto(ticketId: "");
            Assert.ThrowsAsync<ArgumentException>(() => _service.CreateAsync(dto));
        }

        [Test]
        public void CreateAsync_EmptyUserId_ThrowsArgumentException()
        {
            var dto = MakeCreateDto(userId: "");
            Assert.ThrowsAsync<ArgumentException>(() => _service.CreateAsync(dto));
        }

        [Test]
        public async Task CreateAsync_TrimsWhitespaceFromField()
        {
            var dto = MakeCreateDto(field: "  status  ");
            AuditLog? captured = null;
            _repositoryMock
                .Setup(r => r.CreateAsync(It.IsAny<AuditLog>()))
                .Callback<AuditLog>(log => captured = log)
                .ReturnsAsync(MakeAuditLog());

            await _service.CreateAsync(dto);

            Assert.That(captured!.Field, Is.EqualTo("status"));
        }

        [Test]
        public async Task CreateAsync_CallsRepositoryOnce()
        {
            var dto = MakeCreateDto();
            _repositoryMock.Setup(r => r.CreateAsync(It.IsAny<AuditLog>())).ReturnsAsync(MakeAuditLog());

            await _service.CreateAsync(dto);

            _repositoryMock.Verify(r => r.CreateAsync(It.IsAny<AuditLog>()), Times.Once);
        }

        [Test]
        public async Task CreateBulkAsync_ValidDtos_ReturnsAllCreated()
        {
            var dtos = new List<CreateAuditLogDto> { MakeCreateDto("status"), MakeCreateDto("priority") };
            var logs = new List<AuditLog> { MakeAuditLog("log-1"), MakeAuditLog("log-2") };
            _repositoryMock.Setup(r => r.CreateBulkAsync(It.IsAny<IEnumerable<AuditLog>>())).ReturnsAsync(logs);

            var result = (await _service.CreateBulkAsync(dtos)).ToList();

            Assert.That(result.Count, Is.EqualTo(2));
        }

        [Test]
        public async Task CreateBulkAsync_EmptyList_ReturnsEmptyWithoutCallingRepo()
        {
            var result = await _service.CreateBulkAsync(new List<CreateAuditLogDto>());

            Assert.That(result, Is.Empty);
            _repositoryMock.Verify(r => r.CreateBulkAsync(It.IsAny<IEnumerable<AuditLog>>()), Times.Never);
        }

        [Test]
        public void CreateBulkAsync_NullList_ThrowsArgumentNullException()
        {
            Assert.ThrowsAsync<ArgumentNullException>(() => _service.CreateBulkAsync(null!));
        }

        [Test]
        public void CreateBulkAsync_OneInvalidDto_ThrowsArgumentException()
        {
            var dtos = new List<CreateAuditLogDto>
            {
                MakeCreateDto("status"),
                MakeCreateDto(field: "")
            };

            Assert.ThrowsAsync<ArgumentException>(() => _service.CreateBulkAsync(dtos));
        }

        [Test]
        public async Task DeleteByTicketIdAsync_ValidId_CallsRepository()
        {
            _repositoryMock.Setup(r => r.DeleteByTicketIdAsync("ticket-1")).Returns(Task.CompletedTask);

            await _service.DeleteByTicketIdAsync("ticket-1");

            _repositoryMock.Verify(r => r.DeleteByTicketIdAsync("ticket-1"), Times.Once);
        }

        [Test]
        public void DeleteByTicketIdAsync_EmptyId_ThrowsArgumentException()
        {
            Assert.ThrowsAsync<ArgumentException>(() => _service.DeleteByTicketIdAsync(""));
        }

        [Test]
        public void DeleteByTicketIdAsync_WhitespaceId_ThrowsArgumentException()
        {
            Assert.ThrowsAsync<ArgumentException>(() => _service.DeleteByTicketIdAsync("   "));
        }
    }
}