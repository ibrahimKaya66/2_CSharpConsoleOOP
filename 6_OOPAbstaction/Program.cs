using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_OOPAbstaction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dog ve Cat
            //animal ->base,abstract
            //name
            //cinsi
            //cinsiyet
            //Ses()

            Dog d = new Dog();
            d.Sound();
            Cat c = new Cat();
            c.Sound();
            Console.Read();
        }
    }
}
