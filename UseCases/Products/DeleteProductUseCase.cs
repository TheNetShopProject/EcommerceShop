using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces.Products;

namespace UseCases.Products
{
    public class DeleteProductUseCase : IDeleteProductUseCase
    {
        private readonly IProductRepository _productRepository;

        public DeleteProductUseCase(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }

        public void Execute(int productId)
        {
            _productRepository.DeleteProduct(productId);
        }
    }
}
