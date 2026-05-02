using MiniHelpDesk.Data;
using App.Repositories.interfaces;
using App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using App.Models.DTOs;

namespace App.Repositories
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(AppDbContext db) : base(db)
        {
        }

        public async Task<List<CategoryDTO>> GetAllCategories()
        {
            return await _dbSet.Select(c => new CategoryDTO
            {
                CategoryId = c.CategoryId,
                Name = c.Name,
                Info = $"Id: {c.CategoryId} - Name: {c.Name}"
            }).ToListAsync();
        }

        public async Task<Category?> GetCategoryByName(string name)
        {
            return await _dbSet.FirstOrDefaultAsync(x => x.Name == name);
        }
    }
}
