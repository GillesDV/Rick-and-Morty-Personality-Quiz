using PersonalityQuiz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalityQuiz.Data
{
    public class QuestionsAndAnswersDataService : IQuestionsAndAnswersDataService
    {
        private string[,] allQuestionsAndAnswers = new string[10, 4] {
            {"What gender are you?", "Male Human", "Female Human","Other (transgender, Alien, ...)" },
            {"What color of hair do you prefer your partner to have?", "Blonde", "Brown/Black","Red hair" },
            {"", "", "","" },
            {"", "", "","" },
            {"", "", "","" },

            {"", "", "","" },
            {"", "", "","" },
            {"", "", "","" },
            {"", "", "","" },
            {"", "", "","" }
        };

        public QuestionAndAnswers GetQuestionAndAnswers(int questionNumber)
        {
            string question = allQuestionsAndAnswers[questionNumber, 1];
            string answerOne = allQuestionsAndAnswers[questionNumber, 2];
            string answerTwo = allQuestionsAndAnswers[questionNumber, 3];
            string answerThree = allQuestionsAndAnswers[questionNumber, 4];

            return new QuestionAndAnswers(question, answerOne, answerTwo, answerThree);
        }

    }
}
