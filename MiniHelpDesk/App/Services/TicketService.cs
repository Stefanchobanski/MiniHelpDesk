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
            throw new NotImplementedException();
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
            var ticket = TicketRepository.GetByIdAsync(ticketId);

            if (ticket == null)
                throw new Exception("Ticket not found");
        }
    }
}
