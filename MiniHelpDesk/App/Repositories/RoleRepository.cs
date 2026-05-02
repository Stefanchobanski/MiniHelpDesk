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

namespace App.Repositories
{
    public class RoleRepository : BaseRepository<Role>, IRoleRepository
    {
        public RoleRepository(AppDbContext db) : base(db)
        {
        }

        public async Task<Role?> GetRoleByName(string name)
        {
            return await  _dbSet.FirstOrDefaultAsync(r => r.Name.ToLower() == name.ToLower());
        }

        public async Task<List<RoleDTO>> GetRolesAsync()
        {
            return await _db.Roles.Select(r=> new RoleDTO()
            {
                RoleId = r.RoleID,
                Name = r.Name,
                Display = $"{r.RoleID} - {r.Name}"
            }).ToListAsync();
        }

        public async Task RemoveAndSetDeffaut(int id)
        {
            var users =  _db.Users.Where(u => u.RoleID == id).ToList();

            foreach(var user in users)
            {
                user.Role = await GetRoleByName("Null");
            }
            _dbSet.Remove( await GetByIdAsync(id));
            _db.SaveChanges();
        }
    }
}
