using App.Models;
using App.Repositories;
using App.Services.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly CategoryRepository _categoryRepository;

        public CategoryService(CategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<List<Category>> GetCategoriesAsync()
        {
            var categories = _categoryRepository.GetAllAsync() ?? throw new InvalidOperationException("Not found categories");

            return await categories;
        }

        public async Task<Category>? GetCategoryById(int id)
        {
            return await _categoryRepository.GetByIdAsync(id) ?? throw new InvalidOperationException("Not found categories");
        }
    }
}
