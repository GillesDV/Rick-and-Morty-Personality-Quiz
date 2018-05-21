using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalityQuiz.Models
{
    public class QuestionAndAnswers
    {
        public string Question { get; set; }
        public string AnswerOne { get; set; }
        public string AnswerTwo { get; set; }
        public string AnswerThree { get; set; }

        public QuestionAndAnswers(string question, string answerOne, string answerTwo, string answerThree)
        {
            Question = question;
            AnswerOne = answerOne;
            AnswerTwo = answerTwo;
            AnswerThree = answerThree;
        }
    }
}
