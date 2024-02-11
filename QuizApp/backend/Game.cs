using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.backend
{
    public class Game
    {
        public Game()
        {
            Random = new Random();
            CreateQuestions();
            Categories = Questions.Select(x => x.Category).Distinct().OrderBy(x => x).ToList();
            CurrentCategory = Categories[CurrentCategoryIndex];
        }

        public int CurrentCategoryIndex { get; set; }
        public Random Random { get; set; }
        public List<Question> Questions { get; set; }
        public int CurrentCategory { get; set; }
        public List<int> Categories { get; set; }
        public Question CurrentQuestion { get; set; }
        public int Points { get; set; }

        public void CreateQuestions()
        {
            Questions = QuestionCreator.CreateQuestions();
        }

        public void DrawQuestion()
        {
            var questionsFromCurrentCategory = Questions.Where(x => x.Category == CurrentCategory).ToList();
            var number = Random.Next(0, questionsFromCurrentCategory.Count);
            var question = questionsFromCurrentCategory[number];
            question.Answers = question.Answers.OrderBy(x => Random.Next()).ToList();

            for (int i = 0; i < question.Answers.Count; i++)
            {
                question.Answers[i].Number = i + 1;
            }


            CurrentQuestion = question;
        }

        public bool IsCorrectAnswer(int userAnswer)
        {
            var answer = CurrentQuestion.Answers.FirstOrDefault(x => x.Number == userAnswer);
            var isCorrect = answer.IsCorrect;
            Points += CurrentQuestion.Category;
            return isCorrect;
        }

        public bool CheckLastQuestion()
        {
            if (CurrentCategoryIndex < Categories.Count - 1)
            {
                CurrentCategoryIndex++;
                CurrentCategory = Categories[CurrentCategoryIndex];
                return false;
            }
            else
                return true;
        }
    }
}       
