using CoreBusiness;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces.Categories;

namespace UseCases.Categories
{
    public class EditCategoryUseCase :  IEditCategoryUseCase
    {
        private readonly ICategoryRepository _categoryRepository;

        public EditCategoryUseCase(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public void Execute(Category category)
        {
            _categoryRepository.Update(category);
        }
    }
}