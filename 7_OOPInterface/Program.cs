using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_OOPInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Product
           Name,Price,Stock

           ProductManager

           Interface IProductManager
           List<Products> GetAll
           Add
           Remove
           Product Get
            */

            ProductManager productManager = new ProductManager();

            productManager.Add(new Product("telefon", 15, 10000));
            productManager.GetAll().ForEach(i => Console.Write($"{i.Name}"));
            Console.Read();
        }
    }
}
