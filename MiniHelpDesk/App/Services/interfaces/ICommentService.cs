using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Services.interfaces
{
    public interface ICommentService
    {
        Task Add(string comment, DateTime date, int ticketID, int UserId);
    }
}
