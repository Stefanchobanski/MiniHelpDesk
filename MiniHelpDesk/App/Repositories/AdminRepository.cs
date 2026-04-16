using App.Models;
using App.Models.DTOs;
using App.Repositories.interfaces;
using Microsoft.EntityFrameworkCore;
using MiniHelpDesk.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Repositories;

public class AdminRepository : BaseRepository<User>, IAdminRepository
{
    public AdminRepository(AppDbContext db) : base(db) { }

    public async Task<List<UserRoleDTO>> GetAllUserWithRole()
    {
        return await _dbSet.Include(u => u.Role).Select(u => new UserRoleDTO
        {
            UserId = u.UserID,
            UserName = u.Username,
            Email = u.Email,
            Role = u.Role.Name,
            RoleId = u.RoleID,
            Display = $"ID:{u.UserID} - {u.Username} - {u.Email} - {u.Role.Name}"
        }).ToListAsync();
    }

    public async Task<User?> GetUserByNameAsync(string name)
    {
        return await _dbSet.FirstOrDefaultAsync(u => u.Username == name);
    }

}
