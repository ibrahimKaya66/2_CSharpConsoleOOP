using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_OOPQuestion
{
    internal static class QuestionManager
    {
        public static List<Question> Questions { get; set; }
        private static int d = 0;
        private static int y = 0;
        static QuestionManager()
        {
            Questions = new List<Question>() {
                new Question(
                    1,"Türkiyenin başkenti?",
                    new List<string>{"ankara","istanbul","izmir","bursa"},
                    "ankara"
                ),
                new Question(
                    2,"istanbulun fethi?",
                    new List<string>{"1071","1453","1789","1920"},
                    "1453"
                ),
                new Question(
                    1,"en kalabalık ilçe?",
                    new List<string>{"çankaya","nilüfer","esenyurt","kadışehri"},
                    "esenyurt"
                )
            };
        }

        private static int i = 0;
        public static void DisplayQuestion()
        {
            if (i < 3)
            {
                Console.WriteLine($"{Questions.ElementAt(i).No} - {Questions[i].Title}");
                Questions[i].Choices.ForEach(i => Console.Write($"{i}  "));
                Console.Write("\nCevabınız : ");
                string answer = Console.ReadLine();
                if (Questions[i].CheckAnswer(answer))
                    d++;
                else
                    y++;

                i++;
                DisplayQuestion();
            }
            else
                Console.WriteLine($"D : {d} Y = {y}");
        }
    }
}
