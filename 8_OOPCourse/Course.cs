using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_OOPCourse
{
    internal class Course
    {
        private string name;//Ctr+R+E

        public string Name
        {
            get => name;
            set
            {
                if (value.Length < 3 || value.Length > 20)
                    throw new ArgumentException();
                else
                    name = value;
            }
        }

        public int TotalHour { get; set; }
        public int WeeklyHour { get; set; }
        private DateTime startDate;
        public DateTime StartDate
        {
            get => startDate;
            set
            {
                if (value.AddMinutes(1) <= DateTime.Now)
                    throw new ArgumentException();
                else
                    startDate = value;
            }
        }

        public DateTime EndDate { get; set; }
        public List<Student> Students { get; set; }
        public Educator Educator { get; set; }

        public Course()
        {
            this.EndDate = EndDateCalculate();
            Students = new List<Student>();
        }

        public Course(string name, int totalHour, int weeklyHour, DateTime startDate)
        {
            this.Name = name;
            this.TotalHour = totalHour;
            this.WeeklyHour = weeklyHour;
            this.StartDate = startDate;
            this.EndDate = EndDateCalculate();
            Students = new List<Student>();
        }

        private DateTime EndDateCalculate()
        {
            int day = (this.TotalHour / this.WeeklyHour) * 7;
            return this.StartDate.AddDays(day);
        }


    }
}
