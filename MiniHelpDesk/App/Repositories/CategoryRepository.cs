using MiniHelpDesk.Data;
using App.Repositories.interfaces;
using App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Repositories
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(AppDbContext db) : base(db)
        {
        }
    }
}
