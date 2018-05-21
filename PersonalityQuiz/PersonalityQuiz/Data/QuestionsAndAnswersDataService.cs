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
            var arrayIndex = questionNumber - 1;
            string question = allQuestionsAndAnswers[arrayIndex, 0];
            string answerOne = allQuestionsAndAnswers[arrayIndex, 1];
            string answerTwo = allQuestionsAndAnswers[arrayIndex, 2];
            string answerThree = allQuestionsAndAnswers[arrayIndex, 3];

            return new QuestionAndAnswers(question, answerOne, answerTwo, answerThree);
        }

    }
}
