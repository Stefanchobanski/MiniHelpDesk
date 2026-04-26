using App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Services.interfaces
{
    public interface ICategoryService
    {
        public Task<List<Category>>? GetCategoriesAsync();
        public Task<Category>? GetCategoryById(int id);
        public Task AddCategory(string name);
    }
}
