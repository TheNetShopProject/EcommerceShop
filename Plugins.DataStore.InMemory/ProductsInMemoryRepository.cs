using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class ProductsInMemoryRepository : IProductRepository
    {
        private List<Product> Products;
        public ProductsInMemoryRepository()
        {
            Products = new List<Product>
            {
                new Product { ProductId =1, CategoryId = 1, Name="Shampoo", Price = 10, Quantity =1},
                new Product { ProductId =2, CategoryId = 1, Name="Ball", Price = 20, Quantity =14},
                new Product { ProductId =3, CategoryId = 2, Name="Doll", Price = 120, Quantity =3}
            };
        }

        public void AddProduct(Product product)
        {
            if (Products.Any(x => x.Name.Equals(product.Name, StringComparison.OrdinalIgnoreCase))) return;
            if(product != null & Products.Count > 0)
            {
                product.ProductId = Products.Max(x => x.ProductId) + 1;
                Products.Add(product);
                return;
            }
            product.ProductId = 1;
            Products.Add(product);
            return;
            
        }

        public IEnumerable<Product> GetProducts()
        {
            return Products; 
        }
    }
}
