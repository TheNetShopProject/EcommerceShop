using CoreBusiness;
using System.Collections.Generic;
namespace UseCases.UseCaseInterfaces.Products
{
    public interface IViewProductsUseCase
    {
        IEnumerable<Product> Execute();
    }
}