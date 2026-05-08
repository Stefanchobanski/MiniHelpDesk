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
    }
}
