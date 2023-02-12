using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_OOPOrder
{
    internal class Customer : Person
    {
        public List<Product> Products { get; set; }
        public Customer(string name, string surname) : base(name, surname)
        {
            Products = new List<Product>();
        }
        public Customer() : base()
        {
            Products = new List<Product>();
        }
        public Customer(string name, string surname, List<Product> products) : base(name, surname)
        {
            Products = products;
        }
    }
}
