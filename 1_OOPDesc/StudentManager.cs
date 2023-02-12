using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_OOPDesc
{
    internal static  class StudentManager
    {
        public static List<Student> students { get; set; }
        static StudentManager()
        {
            //Değer atama yöntemleri
            //1.yöntem
            Student ogr1 = new Student();
            ogr1.No = 1;
            ogr1.Name = "ibrahim";
            ogr1.Surname = "kaya";
            ogr1.Class_No = 205;
            ogr1.Gender = 'E';
            //ogr1.Info();
            //2.yöntem
            Student ogr2 = new Student
            {//new Student()
                No = 2,
                Name = "ilker",
                Surname = "şenel",
                Class_No = 205,
                Gender = 'E'
            };
            //ogr2.Info();


            //3.yöntem
            Student ogr3 = new Student(3, "sercan", "yöndem", 205, 'E');
            //ogr3.Info();

            students = new List<Student>()
            {
                ogr1,
                ogr2,
                ogr3,
                new Student()
                {
                    No=4,
                    Name = "ayşe",
                    Surname="şensoy",
                    Class_No=205,
                    Gender = 'K'
                },
                new Student(5,"fatih","polat",200,'E'),
                new Student(name : "aslı",surname:"keskin",gender:'K',no:6,class_no:100)
            };
        }

        public static void Add(Student student)
        {
            students.Add(student);
        }

        public static void Remove(Student student)
        {
            students.Remove(student);
        }

        public static void Remove(int index)
        {
            students.RemoveAt(index);
        }
    }
}
