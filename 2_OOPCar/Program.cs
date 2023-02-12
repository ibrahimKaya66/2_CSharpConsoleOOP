using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace _2_OOPCar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Car class
             * 
             Property 
                brand
                model
                color
                isAuto
                yılı
            Metotları
                start()
                    reno clio çalıştırıldı
                Stop()
                SpeedUp
                SLow

            //Main
            iki araç nesnesi üretin ve metotları çağırın
             */

            var renault = new Car("renault", "clio");
            renault.Year = 2028;
            var opel = new Car()
            {
                Brand = "opel",
                Model = "corsa"
            };
            renault.Start();
            opel.Start();
            Console.ReadLine();
        }
    }
}
