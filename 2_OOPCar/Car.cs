using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_OOPCar
{
    internal class Car
    {
        //Encapculation
        //Ctrl+R+E
        private string brand;
        public string Brand { get => brand.ToUpper(); set => brand = value; }
        public string Model { get; set; }

        public string Color { get; set; }
        public bool IsAuto { get; set; }

        private int year;
        public int Year
        {
            get => year;
            set
            {
                if (value > DateTime.Now.Year)
                    year = 2022;
                else if (value < 1990)
                    year = 1990;
                else
                    year = value;
            }
        }



        public Car()
        {

        }
        public Car(string brand, string model)
        {
            this.Brand = brand;
            this.Model = model;
        }
        public void Start()
        {
            Console.WriteLine($"{this.Brand} {this.Model} {this.Year} araç çalıştırıldı");
        }
        public void Stop()
        {
            Console.WriteLine($"{this.Brand} {this.Model} {this.Year} araç durdu");
        }
        public void Speed()
        {
            Console.WriteLine($"{this.Brand} {this.Model} {this.Year} araç hızlandı");
        }
        public void Slow()
        {
            Console.WriteLine($"{this.Brand} {this.Model} {this.Year} araç yavaşladı");
        }
    }
}
