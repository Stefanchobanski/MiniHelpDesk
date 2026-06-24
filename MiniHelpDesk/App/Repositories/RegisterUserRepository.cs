using App.Models;
using App.Repositories;
using App.Repositories.interfaces;
using App.Services.interfaces;
using Microsoft.EntityFrameworkCore;
using MiniHelpDesk.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Repositories
{
    public class RegisterUserRepository : BaseRepository<User>, IRegisterUserRepository
    {
        public RegisterUserRepository(AppDbContext db) : base(db)
        {

        }

        public async Task<bool> ExistsByUsernameAsync(string username)
            => await _dbSet.AnyAsync(u => u.Username == username);

        public async Task<bool> ExistsByEmailAsync(string email)
            => await _dbSet.AnyAsync(u => u.Email == email);

    }
}
