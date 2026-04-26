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

        public async Task AddCategory(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new IndexOutOfRangeException("Трябва да напишете нещо!");
            }

            var category = await _categoryRepository.GetCategoryByName(name);

            if (category is null)
            {
                await _categoryRepository.AddAsync(new Category() { Name = name });
            }
            else
            {
                throw new IndexOutOfRangeException("Тази категория вече съществува");
            }
        }

        public async Task RemoveCategory(int id)
        {
           await _categoryRepository.DeleteAsync(id);
        }
    }
}
