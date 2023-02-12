using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_OOPCourse
{
    internal class Student : User
    {
        public Student() : base()
        {

        }

        public Student(string name, string surname) : base(name, surname)
        {

        }


        public override void JoinCourse(Course course)
        {
            course.Students.Add(this);
            this.Courses.Add(course);
        }
    }
}
