using App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Repositories.interfaces
{
    public interface IRoleRepository : IRepository<Role>
    {
        Task<List<Role>> GetRolesAsync();
    }
}
