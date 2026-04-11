using App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Repositories.interfaces;

public interface IAdminRepository : IRepository<User>
{
    Task<User?> GetUserByNameAsync(string name);
}
