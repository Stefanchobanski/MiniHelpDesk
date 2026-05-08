using App.Models;
using App.Models.DTOs;
using App.Repositories;
using App.Repositories.interfaces;
using App.Services.interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Models.Enums;

namespace App.Services
{

    public class TicketService : ITicketService
    {
        private readonly ITicketRepository _ticketRepository;

        public TicketService(ITicketRepository ticketRepository)
        {
            _ticketRepository = ticketRepository;
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
                //logger
                throw new Exception("Ticket not found");
            }

            ticket.AssignedTo = technicalEmail;
            ticket.Status = App.Models.Enums.Status.InProgress;
            await _ticketRepository.UpdateAsync(ticket);
        }

        public async Task UpdateTicketStatus(int ticketId, App.Models.Enums.Status status)
        {
            var ticket = await _ticketRepository.GetByIdAsync(ticketId);
            if (ticket == null)
            {
                //logger
                throw new Exception("Ticket not found");
            }

            ticket.Status = status;
            await _ticketRepository.UpdateAsync(ticket);
        }

        public async Task DeleteTicket(int ticketId)
        {
            var ticket = await _ticketRepository.GetByIdAsync(ticketId);
            if (ticket != null)
            {
                //logger
                await _ticketRepository.DeleteAsync(ticket.TicketId);
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
                //logger
                throw new IndexOutOfRangeException("Invalid id");
            }

            var tickets = await _ticketRepository.GetAllTicketsForUser(id);

            //Можеш и за проверките да използваш: 
            //ServiceHelper.ObjectIsNull();
            //ServiceHelper.CheckFields();
            if (tickets == null)
            {
                //logger
                throw new Exception("No tickets found for user");
            }

            return tickets.Select(MapToResponse).ToList();
        }
    }
}
