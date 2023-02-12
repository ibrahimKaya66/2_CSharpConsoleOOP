using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_OOPOrder
{
    internal class Order
    {
        public Customer Customer { get; set; }
        public Worker Worker { get; set; }
        public decimal TotalPrice { get; set; }
        public Order(Customer customer, Worker worker)
        {
            Customer = customer;
            Worker = worker;
            TotalPrice = TotalPriceCalculate();
        }
        public Order()
        {
            TotalPrice = TotalPriceCalculate();
        }

        private decimal TotalPriceCalculate()
        {
            decimal total = this.Customer.Products.Sum(p => p.Price);
            return total;
        }

        public override string ToString()
        {

            return $"Müşteri Adı = {this.Customer.Name}Çalışan Adı = {this.Worker.Name}";
        }
    }
}
