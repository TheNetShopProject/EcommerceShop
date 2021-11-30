using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces.Categories;

namespace UseCases.Categories
{
    public class DeleteCategoryUseCase : IDeleteCategoryUseCase
    {
        private readonly ICategoryRepository _categoryRepository;

        public DeleteCategoryUseCase(ICategoryRepository categoryRepository)
        {
            this._categoryRepository = categoryRepository;
        }

        public void Execute(int categoryId)
        {
            _categoryRepository.DeleteCategory(categoryId);
        }
    }
}
