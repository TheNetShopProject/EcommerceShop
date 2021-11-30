using CoreBusiness;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces;
using UseCases.UseCaseInterfaces.Categories;

namespace UseCases.Categories
{
    public class AddCategoryUseCase : IAddCategoryUseCase
    {
        private readonly ICategoryRepository _categoryRepository;

        public AddCategoryUseCase(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public void Execute(Category category)
        {
            _categoryRepository.AddCategory(category);
        }
    }
}