using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_OOPOrder
{
    internal class Worker : Person
    {
        public decimal Salary { get; set; }//Maaşı
        public Worker() : base()
        {

        }
        public Worker(string name, string surname, decimal salary) : base(name, surname)
        {
            Salary = salary;
        }
    }
}
