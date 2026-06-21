using App.Models;
using App.Repositories.interfaces;
using App.Services;
using Microsoft.EntityFrameworkCore;
using MiniHelpDesk.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Repositories
{
    public class CommentRepository : BaseRepository<Comment>, ICommentRepository
    {
        public CommentRepository(AppDbContext db) : base(db)
        {
        }

        public async Task<List<Comment>> GetAllForTicket(int idTicket)
        {
            return await _db.Comments.Where(c=>c.TicketID == idTicket).ToListAsync();
        }
    }
}
