using PersonalityQuiz.Models;

namespace PersonalityQuiz.Data
{
    public interface IQuestionsAndAnswersDataService
    {
        QuestionAndAnswers GetQuestionAndAnswers(int questionNumber);
    }
}