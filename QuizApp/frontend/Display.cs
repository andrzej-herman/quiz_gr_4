using QuizApp.backend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.frontend
{
    public static class Display
    {
        public static void DisplayWelcome()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Witaj w Quizie");
            Console.WriteLine(" Spróbuj odpowiedź na 7 pytań");
            Console.WriteLine(" Powodzenia !!!");
            Console.WriteLine();
            Console.Write(" Naciśnij ENTER, aby rozpocząć grę ... ");
            Console.ReadLine();
        }

        public static int DisplayQuestionAndGetAnswer(Question question)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine($" Pytanie za {question.Category} pkt.");
            Console.WriteLine();
            Console.WriteLine(" " + question.Content);
            Console.WriteLine();
            foreach (var a in question.Answers)
            {
                Console.WriteLine($" {a.Number}. {a.Content}");  
            }
            Console.WriteLine();
            Console.Write(" Naciśnij 1, 2, 3 lub 4 => ... ");
            var answer = Console.ReadLine();
            return int.Parse(answer);
        }


        public static void GameOverText()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine(" Niestety, to nie jest poprawna odpowiedź.");
            Console.WriteLine();
            Console.WriteLine(" KONIEC GRY");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
        }

        public static void GoodAnswerText(int points)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine(" Brawo, to jest poprawna odpowiedź !!!");
            Console.WriteLine();
            Console.WriteLine($" Za to pytanie zdobyłeś/aś {points} pkt.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.Write(" Naciśnij ENTER, aby zobaczyć następne pytanie ... ");
            Console.ReadKey();
        }


        public static void SuccessText(int points)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine(" Brawo, ukonczyłeś/aś cały Quiz !!!");
            Console.WriteLine();
            Console.WriteLine($" Łącznie zdobyłeś/aś {points} pkt. Gratulacje !!!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.ReadLine();

        }



        //public static int DisplayQuestion(Question question)
        //{
        //    Console.Clear();
        //    Console.WriteLine();
        //    Console.WriteLine($" Pytanie za {question.Category} pkt.");
        //    Console.WriteLine();
        //    Console.WriteLine(" " + question.Content);
        //    Console.WriteLine();
        //    foreach (var answer in question.Answers)
        //    {
        //        Console.WriteLine($" {answer.DisplayOrder}. {answer.Content}");
        //    }

        //    Console.WriteLine();
        //    Console.ForegroundColor = ConsoleColor.Yellow;
        //    Console.Write(" Naciśnij 1, 2, 3 lub 4 => ... ");
        //    Console.ForegroundColor = ConsoleColor.White;
        //    var input = Console.ReadLine();
        //    var correct = IsCorrectKey(input);
        //    while (correct == false)
        //    {
        //        ShowQuestion(question);
        //        input = Console.ReadLine();
        //        correct = IsCorrectKey(input);
        //    }

        //    return int.Parse(input);
        //}




    }
}
