using App.Models;
using App.Models.DTOs;
using App.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace App.Services.interfaces
{
    public interface ITicketService
    {
        Task<TicketResponseDTO> CreateTicket(CreateTicketRequestDTO request);

        Task<TicketResponseDTO> GetTicketById(int ticketId);

        IEnumerable<TicketSummaryDTO> GetTicketsByEmail(string email);
        IEnumerable<TicketResponseDTO> GetAllTickets();

        Task AssignTicket(int ticketId, string technicalEmail);
        Task UpdateTicketStatus(int ticketId, App.Models.Enums.Status status);
        Task DeleteTicket(int ticketId);
        Task UpdateTicket(TicketResponseDTO ticketDTO);
    }
}
