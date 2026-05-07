using App.Models;
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
    }
}
