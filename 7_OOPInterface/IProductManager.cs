using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_OOPInterface
{
    internal interface IProductManager
    {
        void Add(Product product);
        void Delete(Product product);
        List<Product> GetAll();
        Product Get(string name);
    }
}
