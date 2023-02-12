using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_OOPInheritanceOr
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             Inheritance(Kalıtım)
            Birden fazla classın ortak property ve mototları bir base classın içerisine alınabilir.

            SubClass:BaseClass
             */
            Educator ibrahim = new Educator(1, "ibrahim", "kaya");
            ibrahim.Gender = Gender.Male;
            ibrahim.KursOlustur();
            Student ilker = new Student(1, "ilker", "şenel");
            ilker.KursaKatıl();
           

            List<Employee> employees = new List<Employee>();
            employees.Add(ilker);
            employees.Add(ibrahim);

            Console.Read();
        }
    }
}
