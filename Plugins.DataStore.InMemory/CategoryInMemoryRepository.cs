using System;
using System.Collections.Generic;
using System.Linq;
using CoreBusiness;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class CategoryInMemoryRepository : ICategoryRepository
    {
        private List<Category> categories;

        public CategoryInMemoryRepository()
        {
            categories = new List<Category>()
            {
                new Category{CategoryId = 1, Name = "Bevarage", Description = "Bevarage"},
                new Category{CategoryId = 2, Name = "Bakery", Description = "Bakery"},
                new Category{CategoryId = 3, Name = "Meat", Description = "Meat"}
            };
        }
        public IEnumerable<Category> GetCategories()
        {
            return categories;
        }

        public void AddCategory(Category category)
        {
            if (categories.Any(x => x.Name.Equals(category.Name, StringComparison.OrdinalIgnoreCase))) return;
            if (categories.Count > 0)
            {
                var maxId = categories.Max(x => x.CategoryId);
                category.CategoryId = maxId + 1;
            }
            else
            {
                category.CategoryId = 1;
            }
            categories.Add(category);
        }

        public void Update(Category category)
        {
            var categoryToUpdate = getCategoryById(category.CategoryId);
            if(categoryToUpdate != null)
                categoryToUpdate = category;
        }

        public Category getCategoryById(int categoryId)
        {
            return categories.SingleOrDefault(x => x.CategoryId == categoryId);
        }

        public void DeleteCategory(int categoryId)
        {
            var category = getCategoryById(categoryId);
            categories.Remove(category);
        }
    }
}