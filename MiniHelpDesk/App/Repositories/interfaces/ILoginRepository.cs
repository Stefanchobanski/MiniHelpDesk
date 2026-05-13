using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Models;

namespace App.Repositories.interfaces
{
    public interface ILoginRepository : IRepository<User>
    {
        Task<User?> GetByUsernameAsync(string username);
    }
}
