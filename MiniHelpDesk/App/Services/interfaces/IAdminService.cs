using App.Models;
using App.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Services.interfaces;

public interface IAdminService
{
    Task ChangeUserRole(string userName, int id);
    Task<List<User>> GetAllUsers();
    Task UpdateUsers(User user);
    Task<List<UserRoleDTO>> GetUsersWithRole();
    Task<User> GetByIdUser(int id);
    Task RemoveUser(int id);
}
