using App.Models;
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

        public async Task<List<Role>> GetRolesAsync()
        {
            return await _db.Roles.ToListAsync();
        }
    }
}
