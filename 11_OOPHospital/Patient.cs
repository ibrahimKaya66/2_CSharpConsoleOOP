using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_OOPHospital
{
    public class Patient : Base
    {
        /*
            Hasta->class
            -adı-> ad ve soyad propertisi için abstract base class
            -soyadı
            -hastalığı
            -Doctor 
         */

        public string Disease { get; set; }//Hastalık
        public Hospital Hospital { get; set; }
        public Doctor Doctor { get; set; }
        public Patient(string name, string surname) : base(name, surname)
        {

        }
        public Patient()
        {

        }
    }
}
