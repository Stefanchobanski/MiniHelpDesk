using App.Models;
using App.Repositories.interfaces;
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


    }
}
