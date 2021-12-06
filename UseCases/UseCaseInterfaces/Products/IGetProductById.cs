using CoreBusiness;

namespace UseCases.UseCaseInterfaces.Products
{
    public interface IGetProductById
    {
        Product Execute(int productId);
    }
}