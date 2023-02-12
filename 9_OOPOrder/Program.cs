using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_OOPOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* IEntity
               *name
               *
           //Product:IEntity
           /*
            name,
           category
           price

           //Person:IEntity
           name,
           surname

           Customer:Person
           name,
           soyad,
           List<Product> Products

           Worker:Person
           name,
           soyad,
           maaşı

           //Order-class
           Customer
           Worker
           TotalPrice

           //OrderManager
           List<Order> Orders
           Add()
           Sil()
            */


            var p1 = new Product()
            {
                Name = "iphone",
                Category = "telefon",
                Price = 10000
            };
            var p2 = new Product("ps5", "Konsol", 15000);
            var p3 = new Product(name: "samsung Tv", category: "TV", price: 12000);

            var c1 = new Customer()
            {
                Name = "ibrahim",
                Surname = "kaya"
            };

            var c2 = new Customer("ilker", "şenel");

            var c3 = new Customer("atakan", "değer", new List<Product>() { p1, p2, new Product("scooter", "scooter", 10000) });
            Console.WriteLine("Müşteri 3 ün almış olduğu ürünler");
            c3.Products.ForEach(p => Console.WriteLine(p.Name + " " + p.Price));

            var w1 = new Worker("ibrahim", "çim", 15000);

            var o1 = new Order(c3, w1);

            Console.WriteLine(o1.TotalPrice);

            OrderManager om = new OrderManager();
            om.Add(o1);
            om.Add(new Order(c2, w1));
            om.Orders.ForEach(o => Console.WriteLine(o));
            Console.Read();
        }
    }
}
