using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_OOPCourse
{
    internal class Educator : User
    {
        public Educator() : base()
        {

        }
        public Educator(string n, string s) : base(n, s)
        {

        }

        public override void JoinCourse(Course course)
        {
            this.Courses.Add(course);
            course.Educator = this;
        }
    }
}
