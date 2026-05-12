using App.Models;
using App.Models.DTOs;
using App.Repositories.interfaces;
using App.Services;
using Microsoft.Extensions.Logging.Abstractions;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_Tests
{
    public class CategoryServiceTests
    {
        private Mock<ICategoryRepository> _categoryMockRepo;
        private CategoryService _categoryService;

        [SetUp]
        public void Setup()
        {
            _categoryMockRepo = new Mock<ICategoryRepository>();
            var logger = NullLogger<CategoryService>.Instance;
            _categoryService = new CategoryService(_categoryMockRepo.Object, logger);
        }

        [TearDown]
        public void TearDown()
        {
        }

        private Category CreateCategory(string name)
        {
            return new Category
            { Name = name };
        }
        private CategoryDTO ConvertToDTO(Category category)
        {
            return new CategoryDTO()
            {
                CategoryId = category.CategoryId,
                Info = $"Id: {category.CategoryId} - {category.Name}",
                Name = category.Name
            };
        }


        #region GetCategoriesAsync()
        [Test]
        public async Task GetCategoriesAsync_Success_Test()
        {
            var category1 = ConvertToDTO(CreateCategory("IT"));
            var category2 = ConvertToDTO(CreateCategory("dsdsds"));
            var category3 = ConvertToDTO(CreateCategory("zzzzz"));

            var list = new List<CategoryDTO>()
            {
                category1,
                category2,
                category3
            };

            _categoryMockRepo.Setup(r => r.GetAllCategories()).ReturnsAsync(list);

            var resut = await _categoryService.GetCategoriesAsync();

            Assert.That(resut, Is.Not.Null);
            Assert.That(resut.Contains(category3));
            Assert.That(resut.Contains(category1));
            Assert.That(resut.Contains(category2));

            _categoryMockRepo.Verify(r => r.GetAllCategories(), Times.Once);
        }
        [Test]
        public void GetCategoriesAsync_ThrowExeption_Test()
        {
            _categoryMockRepo.Setup(r=>r.GetAllCategories()).ReturnsAsync(It.IsAny<List<CategoryDTO>>());
            Assert.ThrowsAsync<InvalidOperationException>(() => _categoryService.GetCategoriesAsync());

            _categoryMockRepo.Verify(r => r.GetAllCategories(), Times.Never);
        }
        #endregion
    }
}
