using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_OOPQuestion
{
    internal class Question
    {
        public int No { get; set; }
        public string Title { get; set; }
        //public List<string> Choices { get; set; }
        public List<string> Choices = new List<string>();
        public string Answer { get; set; }

        public Question()
        {
            //Choices= new List<string>();
        }
        public Question(int no, string title, List<string> choices, string answer)
        {
            No = no;
            Title = title;
            //Choices = new List<string>(choices);
            Choices = choices;
            Answer = answer;
        }
        public bool CheckAnswer(string answer)
        {
            if (this.Answer == answer.ToLower())
                return true;
            else
                return false;
        }
    }
}
