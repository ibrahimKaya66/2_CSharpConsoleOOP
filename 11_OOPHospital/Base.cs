using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_OOPHospital
{
    public abstract class Base
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Base(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
        public Base()
        {

        }
    }
}
