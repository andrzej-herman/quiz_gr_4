using QuizApp.backend;
using QuizApp.frontend;
var game = new Game();
game.CreateQuestions();
Display.DisplayWelcome();
game.DrawQuestion();
Display.DisplayQuestion(game.CurrentQuestion);







Console.ReadLine();