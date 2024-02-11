using QuizApp.backend;
using QuizApp.frontend;
var game = new Game();
Display.DisplayWelcome();

while(true)
{
    game.DrawQuestion();
    var userAnswer = Display.DisplayQuestionAndGetAnswer(game.CurrentQuestion);
    if (game.IsCorrectAnswer(userAnswer))
    {
        var isLastQuestion = game.CheckLastQuestion();
        if (isLastQuestion)
        {
            Display.SuccessText(game.Points);
            break;
        }
        else
        {
            Display.GoodAnswerText(game.CurrentQuestion.Category);
        }
    }
    else
    {
        Display.GameOverText();
        break;
    }

}


