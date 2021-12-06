using CoreBusiness;
using System.Collections.Generic;

namespace UseCases.UseCaseInterfaces.Products
{
    public interface IGetProductsByCategoryIdUseCase
    {
        IEnumerable<Product> Execute(int categoryId);
    }
}