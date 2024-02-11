using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace QuizApp.backend
{
    public static class QuestionCreator
    {
        public static List<Question> CreateQuestions()
        {
            var path = Directory.GetCurrentDirectory() + "\\questions.json";
            var content = File.ReadAllText(path);
            return JsonSerializer.Deserialize<List<Question>>(content);
        }
    }
}
