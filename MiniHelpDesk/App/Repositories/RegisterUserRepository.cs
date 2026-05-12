using App.Models;
using App.Repositories;
using App.Repositories.interfaces;
using App.Services.interfaces;
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
    }
}
