using App.Models;
using App.Models.DTOs;
using App.Repositories;
using App.Repositories.interfaces;
using App.Services.interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly ILogger<CategoryService> _logger;

        public CategoryService(ICategoryRepository categoryRepository, ILogger<CategoryService> logger)
        {
            _categoryRepository = categoryRepository;
            _logger = logger;
        }

        public async Task<List<CategoryDTO>> GetCategoriesAsync()
        {
            var categories = _categoryRepository.GetAllCategories();

            ServiceHelper.ObjectIsNull(categories, _logger);

            _logger.LogInformation("Успешно взети категории!");

            return await categories;
        }

        public async Task<Category>? GetCategoryById(int id)
        {
            var category = await _categoryRepository.GetByIdAsync(id);

            ServiceHelper.ObjectIsNull(category, _logger);

            _logger.LogInformation("Успешно взета категория!");

            return category;
        }

        public async Task AddCategory(string name)
        {
            ServiceHelper.CheckFields(name, _logger, "Категорията ");

            var category = await _categoryRepository.GetCategoryByName(name);

            if (category is null)
            {
                _logger.LogInformation("Категорията не съществува, добавям нова категория");
                await _categoryRepository.AddAsync(new Category() { Name = name });
            }
            else
            {
                _logger.LogError("Тази категория вече съществува");
                throw new IndexOutOfRangeException("Тази категория вече съществува");
            }
        }

        public async Task RemoveCategory(int id)
        {
            await _categoryRepository.DeleteAsync(id);
        }

        public async Task UpdateCategory(int id, string newName)
        {
            ServiceHelper.CheckFields(newName, _logger, "Категорията ");

            var category = await _categoryRepository.GetByIdAsync(id);

            ServiceHelper.ObjectIsNull(category, _logger);

            category.Name = newName;

            _logger.LogInformation("Успешно промененена категория!");

            await _categoryRepository.UpdateAsync(category);
        }
    }
}