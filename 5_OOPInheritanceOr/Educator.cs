using System;

namespace _5_OOPInheritanceOr
{
    internal class Educator:Employee
    {
        public Educator(int id, string name, string surname) : base(id, name, surname)
        {
        }
        public Educator() : base()
        {

        }
        public Educator(int id, string name, string surname,Gender gender):base(id,name, surname, gender)
        {

        }
        public void KursOlustur()
        {
            Console.WriteLine("Kurs Oluşturuldu");
        }
    }
}