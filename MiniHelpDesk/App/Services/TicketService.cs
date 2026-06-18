using App.Models;
using App.Models.DTOs;
using App.Models.Enums;
using App.Repositories;
using App.Repositories.interfaces;
using App.Services.interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Services
{

    public class TicketService : ITicketService
    {
        private readonly ITicketRepository _ticketRepository;
        private readonly ILogger<TicketService> _logger;

        public TicketService(ITicketRepository ticketRepository, ILogger<TicketService> logger)
        {
            _ticketRepository = ticketRepository;
            _logger = logger;
        }

        public async Task<TicketResponseDTO> CreateTicket(CreateTicketRequestDTO request)
        {
            var ticket = new Ticket
            {
                Email = request.Email,
                Description = request.Description,
                Status = App.Models.Enums.Status.New
            };

            await _ticketRepository.AddAsync(ticket);
            return MapToResponse(ticket);
        }

        public async Task<TicketResponseDTO> GetTicketById(int ticketId)
        {
            var ticket = await _ticketRepository.GetByIdAsync(ticketId);
            return ticket == null ? null : MapToResponse(ticket);
        }

        public IEnumerable<TicketSummaryDTO> GetTicketsByEmail(string email)
        {
            return _ticketRepository.GetByEmail(email)
                .Select(t => new TicketSummaryDTO
                {
                    TicketId = t.TicketId,
                    Status = t.Status.ToString()
                });
        }

        public IEnumerable<TicketResponseDTO> GetAllTickets()
        {
            return _ticketRepository.GetAllTickets().Select(MapToResponse);
        }

        public async Task AssignTicket(int ticketId, string technicalEmail)
        {
            var ticket = await _ticketRepository.GetByIdAsync(ticketId);
            if (ticket == null)
            {
                _logger.LogError($"Ticket with ID {ticketId} was not found");
                throw new Exception("Ticket not found");
            }
            _logger.LogInformation($"Ticket {ticketId} assigned to technician {technicalEmail}");

            ticket.AssignedTo = technicalEmail;
            ticket.Status = App.Models.Enums.Status.InProgress;
            await _ticketRepository.UpdateAsync(ticket);
        }

        public async Task UpdateTicketStatus(int ticketId, App.Models.Enums.Status status)
        {
            var ticket = await _ticketRepository.GetByIdAsync(ticketId);
            if (ticket == null)
            {
                _logger.LogError($"Ticket with ID {ticketId} was not found");
                throw new Exception("Ticket not found");
            }
            _logger.LogInformation($"Ticket {ticketId} status updated to {status}");

            ticket.Status = status;
            await _ticketRepository.UpdateAsync(ticket);
        }

        public async Task DeleteTicket(int ticketId)
        {
            var ticket = await _ticketRepository.GetByIdAsync(ticketId);
            if (ticket != null)
            {
                _logger.LogInformation($"Deleting ticket with ID {ticket.TicketId}");
                await _ticketRepository.DeleteAsync(ticket.TicketId);
            }
            else
            {
                _logger.LogWarning($"Attempted to delete non-existing ticket with ID {ticketId}");
            }
        }

        public async Task UpdateTicket(TicketResponseDTO ticketDTO)
        {
            var ticket = await _ticketRepository.GetByIdAsync(ticketDTO.TicketId);

            if (ticket == null) return;

            if (!string.IsNullOrWhiteSpace(ticketDTO.Email))
                ticket.Email = ticketDTO.Email;

            if (!string.IsNullOrWhiteSpace(ticketDTO.Description))
                ticket.Description = ticketDTO.Description;

            if (!string.IsNullOrWhiteSpace(ticketDTO.Status))
                ticket.Status = Enum.Parse<Status>(ticketDTO.Status);

            if (!string.IsNullOrWhiteSpace(ticketDTO.AssignedTo))
                ticket.AssignedTo = ticketDTO.AssignedTo;

            if (ticketDTO.CreatedAt != default)
                ticket.CreatedAt = ticketDTO.CreatedAt;

            if (!string.IsNullOrWhiteSpace(ticketDTO.Title))
                ticket.Title = ticketDTO.Title;

            if (!string.IsNullOrWhiteSpace(ticketDTO.Priority) &&
                Enum.TryParse<Priority>(ticketDTO.Priority, out var priority))
                ticket.Priority = priority;

            if (ticketDTO.RequesterId.HasValue && ticketDTO.RequesterId != 0)
                ticket.RequesterId = ticketDTO.RequesterId.Value;

            if (ticketDTO.TechnicianId.HasValue && ticketDTO.TechnicianId != 0)
                ticket.TechnicianId = ticketDTO.TechnicianId.Value;

            if (ticketDTO.CategoryId.HasValue && ticketDTO.CategoryId != 0)
                ticket.CategoryId = ticketDTO.CategoryId.Value;

            await _ticketRepository.SaveChanges();
        }

        private TicketResponseDTO MapToResponse(Ticket ticket)
        {
            return new TicketResponseDTO
            {
                TicketId = ticket.TicketId,
                Email = ticket.Email,
                Description = ticket.Description,
                Status = ticket.Status.ToString(),
                AssignedTo = ticket.AssignedTo,
                CreatedAt = ticket.CreatedAt,
                Title = ticket.Title,
                Priority = ticket.Priority.ToString(),
                RequesterId = ticket.RequesterId,
                TechnicianId = ticket.TechnicianId,
                CategoryId = ticket.CategoryId
            };
        }

        public async Task<List<TicketResponseDTO>> GetAllTicketsForUser(int id)
        {
            if (id < 0)
            {
                _logger.LogError($"Invalid user ID: {id}");
                throw new IndexOutOfRangeException("Invalid id");
            }

            var tickets = await _ticketRepository.GetAllTicketsForUser(id);

            //Можеш и за проверките да използваш: 
            //ServiceHelper.ObjectIsNull();
            //ServiceHelper.CheckFields();
            if (tickets == null)
            {
                _logger.LogError($"No tickets found for user with ID {id}");
                throw new Exception("No tickets found for user");
            }

            return tickets.Select(MapToResponse).ToList();
        }

        public async Task<List<User>> GetTechnicianUsers(int id)
        {
            try
            {
                var users = await _ticketRepository.GetTechnicianUsers(id);
                ServiceHelper.ObjectIsNull(users, _logger);

                return users;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message + " " + ex.StackTrace);
                throw new Exception("Възникна грешка");
            }
        }

        public async Task<List<TicketResponseDTO>> GetAllTicketTechnic(int techId, int userId)
        {
            try
            {
                var tickets = await _ticketRepository.GetAllTicketTechnic(techId, userId);
                ServiceHelper.ObjectIsNull(tickets, _logger);

                return tickets.Select(t => MapToResponse(t)).ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError($"{ex.Message} {ex.StackTrace}");
                throw new Exception("Възникна грешка");
            }
        }

        public async Task<List<CommentDTO>> GetTicketComments(int id)
        {
            try
            {
                var comments = await _ticketRepository.GetTicketComments(id);
                ServiceHelper.ObjectIsNull(comments, _logger);

                return comments.Select(c => new CommentDTO
                {
                    CommentID = c.CommentID, 
                    Text = c.Text,
                    CreatedDate = c.CreatedDate
                }).ToList();

            }
            catch (Exception ex)
            {
                _logger.LogError($"{ex.Message} {ex.StackTrace}");
                throw new Exception("Възникна грешка");
            }
        }
    }
}
