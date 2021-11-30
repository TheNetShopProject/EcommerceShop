using CoreBusiness;

namespace UseCases.UseCaseInterfaces.Categories
{
    public interface IGetCategoryByIdUseCase
    {
        Category Execute(int categoryId);
    }
}