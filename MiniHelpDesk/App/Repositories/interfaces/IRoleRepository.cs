using App.Models;
using App.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Repositories.interfaces
{
    public interface IRoleRepository : IRepository<Role>
    {
        Task<List<RoleDTO>> GetRolesAsync();
        Task<Role?> GetRoleByName(string name);
        Task RemoveAndSetDeffaut(int id);
    }
}
