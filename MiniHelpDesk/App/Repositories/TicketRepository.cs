using App.Models;
using App.Models.DTOs;
using App.Repositories.interfaces;
using Microsoft.EntityFrameworkCore;
using MiniHelpDesk.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Repositories
{
    public class TicketRepository : BaseRepository<Ticket>, ITicketRepository
    {

        public TicketRepository(AppDbContext db) : base(db) { }
        public IEnumerable<Ticket> GetByEmail(string email)
        {
            return _db.Tickets
                .Where(t => t.Email == email)
                .ToList();
        }

        public IEnumerable<Ticket> GetAllTickets()
        {
            return _db.Tickets.ToList();
        }

        public Task<List<Ticket>> GetAllTicketsForUser(int id)
        {
            return _dbSet
                .Where(t => t.RequesterId == id || t.TechnicianId == id)
                .ToListAsync();
        }

        public async Task<List<User>> GetTechnicianUsers(int id)
        {
            return await _db.Users
            .Where(u => u.TicketToRequest.Any(t => t.TechnicianId == id))
            .ToListAsync();
        }

        public async Task<List<Ticket>> GetAllTicketTechnic(int techId, int userId)
        {
            return await _db.Tickets.Where(t => t.RequesterId == userId)
                .Where(t => t.TechnicianId == techId)
                .ToListAsync();
        }

        public async Task<List<Comment>> GetTicketComments(int id)
        {
            return await _db.Comments.Where(c => c.TicketID == id).ToListAsync();
        }

        public async Task<List<Ticket>> GetTicketFromRequester(int id)
        {
            return await _db.Tickets.Where(t => t.RequesterId == id).ToListAsync();
        }
    }
}
