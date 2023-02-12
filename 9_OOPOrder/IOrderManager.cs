using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_OOPOrder
{
    internal interface IOrderManager
    {
        List<Order> Orders { get; set; }

        void Add(Order order);

        void Remove(Order order);
    }
}
