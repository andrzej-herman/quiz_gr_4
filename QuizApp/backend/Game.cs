using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.backend
{
    public class Game
    {
        public List<Question> Questions { get; set; }
        public int CurrentCategory { get; set; } = 100;

        public void CreateQuestions()
        {
            Questions = new List<Question>();
            var q1 = new Question();
            q1.Category = 100;
            q1.Content = "Jak miał na imię Einstein?";
            q1.Answer1 = "Albert";
            q1.Answer2 = "Adam";
            q1.Answer3 = "Adrian";
            q1.Answer4 = "John";

            Questions.Add(q1);

            var q2 = new Question();
            q2.Category = 200;
            q2.Content = "Jaka jest stolica Chile?";
            q2.Answer1 = "Santiago";
            q2.Answer2 = "Pabianice";
            q2.Answer3 = "Bogota";
            q2.Answer4 = "Caracas";

            Questions.Add(q2);
        }

        // teraz "losowanie" pytania;

    }
}       
