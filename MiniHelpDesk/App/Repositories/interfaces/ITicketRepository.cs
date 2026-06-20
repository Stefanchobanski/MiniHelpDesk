using App.Models;
using App.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Repositories.interfaces
{
    public interface ITicketRepository : IRepository<Ticket>
    {
        IEnumerable<Ticket> GetByEmail(string email);

        IEnumerable<Ticket> GetAllTickets();
        Task SaveChanges();
        Task<List<Ticket>> GetAllTicketsForUser(int id);
        Task<List<Ticket>> GetAllTicketTechnic(int techId, int userId);
        Task<List<User>> GetTechnicianUsers(int id);
        Task<List<Comment>> GetTicketComments(int id);
    }
}
