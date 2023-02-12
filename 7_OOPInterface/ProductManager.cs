using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_OOPInterface
{
    internal class ProductManager:IProductManager
    {
        public List<Product> Products { get; set; }
        public ProductManager()
        {
            Products = new List<Product>();
        }
        public void Add(Product product)
        {
            Products.Add(product);
        }

        public void Delete(Product product)
        {
            Products.Remove(product);
        }

        public Product Get(string name)
        {
            var product = Products.FirstOrDefault(p => p.Name == name);
            return product;
        }

        public List<Product> GetAll()
        {
            return Products;
        }
    }
}
