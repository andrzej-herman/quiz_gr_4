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

        public static void DisplayQuestion(Question question)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine($" Pytanie za {question.Category} pkt.");
            Console.WriteLine();
            Console.WriteLine(" " + question.Content);
            Console.WriteLine();
            var n = 1;
            foreach (var a in question.Answers)
            {
                Console.WriteLine($" {n}. {a}");
                n++;
            }
            Console.WriteLine();
            Console.Write(" Naciśnij 1, 2, 3 lub 4 => ... ");
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
