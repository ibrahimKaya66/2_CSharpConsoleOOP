using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_OOPPerson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person class
            /*
             name 
            surname - büyük harfle
            doğum yılı - 1900 ile - 2022
            private int yasHesapla()
            public void YazYazdır

            //Main

             */
            var ibrahim = new Person("ibrahim", "kaya", 1993);
            ibrahim.AgePrint();
            Console.Read();
        }
    }
}
