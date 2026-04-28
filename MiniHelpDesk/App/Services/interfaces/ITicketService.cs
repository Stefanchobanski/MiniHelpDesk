using App.Models;
using App.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Services.interfaces
{
    public interface ITicketService
    {
        TicketResponseDTO CreateTicket(CreateTicketRequestDTO request);
        TicketResponseDTO GetTicketById(int ticketId);
        IEnumerable<TicketSummaryDTO> GetTicketsByEmail(string email);

        void UpdateTicketStatus(int ticketId, string status);
    }
}
