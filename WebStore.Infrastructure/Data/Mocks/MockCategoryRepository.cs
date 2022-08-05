using System.Collections.Generic;
using WebStore.Core.Entities;
using WebStore.Core.Interfaces;

namespace WebStore.Infrastructure.Data.Mocks
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Strings", Description=""},
                new Category{CategoryId=2, CategoryName="Woodwind", Description=""},
                new Category{CategoryId=3, CategoryName="Keyboards", Description=""}
            };
    }
}
