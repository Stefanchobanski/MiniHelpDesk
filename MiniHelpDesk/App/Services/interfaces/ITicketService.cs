using App.Models;
using App.Models.DTOs;
using App.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Services.interfaces
{
    public interface ITicketService
    {
        Task<TicketResponseDTO> CreateTicket(CreateTicketRequestDTO request);
        Task<TicketResponseDTO> GetTicketById(int ticketId);
        IEnumerable<TicketSummaryDTO> GetTicketsByEmail(string email);

        Task UpdateTicketStatus(int ticketId, Status status);
    }
}
