using App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Repositories.interfaces
{
    public interface IRegisterUserRepository : IRepository<User>
    {
        Task AddAsync(Models.User user);
    }
}
