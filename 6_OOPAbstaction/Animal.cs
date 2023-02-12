using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_OOPAbstaction
{
    internal abstract class Animal
    {
        public string Name { get; set; }
        public string Type { get; set; }//Cinsi
        public Gender Gender { get; set; }
        public abstract void Sound();//virtual da yazılabilir.
        //public void Sound()
        //{
        //    Console.WriteLine("değer");
        //}
        public Animal()
        {

        }

    }
    internal enum Gender
    {
        Unknown,
        Male,
        Female
    }
}
