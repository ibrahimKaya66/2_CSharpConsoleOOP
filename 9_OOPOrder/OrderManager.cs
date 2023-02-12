using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_OOPOrder
{
    internal  class OrderManager:IOrderManager
    {
        public  List<Order> Orders { get; set; } = new List<Order>();

        public  void Add(Order order)
        {
            Orders.Add(order);
        }

        public  void Remove(Order order)
        {
            Orders.Remove(order);
        }
    }
}
