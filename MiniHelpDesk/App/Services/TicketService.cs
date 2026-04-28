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
       
        private readonly ITicketRepository TicketRepository;
        public TicketService(ITicketRepository ticketRepository)
        {
            TicketRepository = ticketRepository;
        }
        public void CheckedEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                throw new ArgumentException("Email is required");
        }

        public TicketResponseDTO CreateTicket(CreateTicketRequestDTO request)
        {
            if (string.IsNullOrWhiteSpace(request.Email))
                throw new ArgumentException("Email is required");

            if (string.IsNullOrWhiteSpace(request.Description))
                throw new ArgumentException("Description is required");

            var ticket = new Ticket
            {
                Description = request.Description,
                Status = Status.New
            };

            TicketRepository.Add(ticket);

            return new TicketResponseDTO
            {
                TicketId = ticket.TicketId,
                Description = ticket.Description,
                Status = ticket.Status.ToString() 
            };
        }

        public TicketResponseDTO GetTicketById(int ticketId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TicketSummaryDTO> GetTicketsByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public void UpdateTicketStatus(int ticketId, string status)
        {
            var ticket =  TicketRepository.GetByIdAsync(ticketId);

            if (ticket == null)
                throw new Exception("Ticket not found");
        }

    }
}
