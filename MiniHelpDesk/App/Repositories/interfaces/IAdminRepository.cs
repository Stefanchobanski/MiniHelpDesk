using App.Models;
using App.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Repositories.interfaces;

public interface IAdminRepository : IRepository<User>
{
    Task<User?> GetUserByNameAsync(string name);
    Task<List<UserRoleDTO>> GetAllUserWithRole();
    Task RemoveTicketByUserAllTabels(User user);
}
