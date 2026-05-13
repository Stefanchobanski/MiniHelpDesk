using App.Models;
using App.Repositories.interfaces;
using Microsoft.EntityFrameworkCore;
using MiniHelpDesk.Data;

namespace App.Repositories
{
    public class LoginRepository : BaseRepository<User>, ILoginRepository
    {
        public LoginRepository(AppDbContext db) : base(db) { }

        public async Task<User?> GetByUsernameAsync(string username) => await _dbSet.FirstOrDefaultAsync(u => u.Username == username);
    }
}
