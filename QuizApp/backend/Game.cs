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
        public Question CurrentQuestion { get; set; }

        public void CreateQuestions()
        {
            Questions = new List<Question>();
            var q1 = new Question();
            q1.Category = 100;
            q1.Content = "Jak miał na imię Einstein?";
            q1.Answers.Add("Albert");
            q1.Answers.Add("Adam");
            q1.Answers.Add("John");
            q1.Answers.Add("Adrian");
            Questions.Add(q1);
        }

        public void DrawQuestion()
        {
            CurrentQuestion = Questions[0];
        }

       

    }
}       
