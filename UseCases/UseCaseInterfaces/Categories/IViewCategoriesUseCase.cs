using System.Collections.Generic;
using CoreBusiness;

namespace UseCases.UseCaseInterfaces.Categories
{
    public interface IViewCategoriesUseCase
    {
        IEnumerable<Category> Execute();
    }
}