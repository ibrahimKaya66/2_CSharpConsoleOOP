using System;

namespace _5_OOPInheritanceOr
{
    internal class Student : Employee
    {
        public Student(int id, string name, string surname) : base(id, name, surname)
        {
        }
        public Student() : base()
        {

        }
        public Student(int id, string name, string surname, Gender gender) : base(id, name, surname, gender)
        {

        }
        public void KursaKatıl()
        {
            Console.WriteLine("Kursa katıldı");
        }
    }
}