using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_OOPDesc
{
    internal class Student
    {
        public int No { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Class_No { get; set; }
        public char Gender { get; set; }

        public void Info()
        {
            Console.WriteLine($"no : {this.No} ad: {this.Name} soyad : {this.Surname} sınıf :  {this.Class_No} cinsiyet:{this.Gender}");
        }
        public Student()
        {

        }
        //Overload
        public Student(int no, string name, string surname, int class_no, char gender)
        {
            this.No = no;
            this.Name = name;
            this.Surname = surname;
            this.Gender = gender;
            this.Class_No = class_no;
            this.Gender = gender;

        }
    }
}
