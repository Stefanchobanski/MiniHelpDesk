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
            if (ticket == null) throw new Exception("Ticket not found");

            ticket.AssignedTo = technicalEmail;
            ticket.Status = App.Models.Enums.Status.InProgress;
            await _ticketRepository.UpdateAsync(ticket);
        }

        public async Task UpdateTicketStatus(int ticketId, App.Models.Enums.Status status)
        {
            var ticket = await _ticketRepository.GetByIdAsync(ticketId);
            if (ticket == null) throw new Exception("Ticket not found");

            ticket.Status = status;
            await _ticketRepository.UpdateAsync(ticket);
        }

        public async Task DeleteTicket(int ticketId)
        {
            var ticket = await _ticketRepository.GetByIdAsync(ticketId);
            if (ticket != null)
                await _ticketRepository.DeleteAsync(ticket.TicketId);
        }

        private TicketResponseDTO MapToResponse(Ticket ticket)
        {
            return new TicketResponseDTO
            {
                TicketId = ticket.TicketId,
                Email = ticket.Email,
                Description = ticket.Description,
                Status = ticket.Status.ToString(),
                AssignedTo = ticket.AssignedTo
            };
        }
    }
}
