using App.Models;
using App.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Services.interfaces
{
    public interface ICategoryService
    {
        public Task<List<CategoryDTO>>? GetCategoriesAsync();
        public Task<Category>? GetCategoryById(int id);
        public Task AddCategory(string name);
        public Task RemoveCategory(int id);
        public Task UpdateCategory(int id, string newName);
    }
}
