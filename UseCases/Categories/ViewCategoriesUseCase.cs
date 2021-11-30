using System.Collections.Generic;
using System.ComponentModel;
using CoreBusiness;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces.Categories;

namespace UseCases.Categories
{
    public class ViewCategoriesUseCase : IViewCategoriesUseCase
    {
        private readonly ICategoryRepository _categoryRepository;

        public ViewCategoriesUseCase(ICategoryRepository CategoryRepository)
        {
            _categoryRepository = CategoryRepository;
        }
        public IEnumerable<Category> Execute()
        {
            return _categoryRepository.GetCategories();
        }
    }
}