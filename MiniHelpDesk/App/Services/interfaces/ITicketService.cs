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
        Task CreateTicket(Ticket request);

        Task<TicketResponseDTO> GetTicketById(int ticketId);

        IEnumerable<TicketSummaryDTO> GetTicketsByEmail(string email);
        IEnumerable<TicketResponseDTO> GetAllTickets();

        Task AssignTicket(int ticketId, string technicalEmail);
        Task UpdateTicketStatus(int ticketId, App.Models.Enums.Status status);
        Task DeleteTicket(int ticketId);
        Task UpdateTicket(TicketResponseDTO ticketDTO);
        Task<List<TicketResponseDTO>> GetAllTicketsForUser(int id);
        Task<List<User>> GetTechnicianUsers(int id);
        Task<List<TicketResponseDTO>> GetAllTicketTechnic(int techId, int userId);
        Task<List<CommentDTO>> GetTicketComments(int id);
        Task<List<Ticket>> GetAllTicketFromRequester(int id);
    }
}
