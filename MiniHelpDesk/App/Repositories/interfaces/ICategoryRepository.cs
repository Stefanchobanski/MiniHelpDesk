using App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Repositories.interfaces
{
    public interface ICategoryRepository : IRepository<Category>
    {
        public Task<Category?> GetCategoryByName(string name);
    }
}
