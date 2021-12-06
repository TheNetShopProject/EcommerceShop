using CoreBusiness;
using System.Collections.Generic;

namespace UseCases.DataStorePluginInterfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        void AddProduct(Product product);
        Product GetProductById(int productId);
        void Update(Product product);
        void DeleteProduct(int productId);
        IEnumerable<Product> GetProductsByCategoryId(int categoryId);
    }
}