﻿using System;
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
                new Category{CategoryId = 1, Name = "Bakery", Description = "Bakery"},
                new Category{CategoryId = 1, Name = "Meat", Description = "Meat"}
            };
        }
        public IEnumerable<Category> GetCategories()
        {
            return categories;
        }

        public void AddCategory(Category category)
        {
            if (categories.Any(x => x.Name.Equals(category.Name, StringComparison.OrdinalIgnoreCase))) return;
            var maxId = categories.Max(x => x.CategoryId);
            category.CategoryId = maxId + 1;
            categories.Add(category);
        }
    }
}