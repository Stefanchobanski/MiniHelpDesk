using App.Models;
using App.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Services.interfaces
{
    public interface IRoleService
    {
        Task<List<RoleDTO>> GetRolesAsync();
        Task<Role?> GetRoleByName(string name);
        Task RemoveRole(int id);
        Task AddRole(string name);
        Task UpdateRole(int id, string newName);
    }
}
