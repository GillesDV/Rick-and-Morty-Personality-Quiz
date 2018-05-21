using PersonalityQuiz.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonalityQuiz.Controllers
{
    public class QuizController : Controller
    {
        private IQuestionsAndAnswersDataService _questionsAndAnswersDataServices = new QuestionsAndAnswersDataService();

        // GET: Quiz
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Question1()
        {
            var questionAndAnswers = _questionsAndAnswersDataServices.GetQuestionAndAnswers(1);

            return View("Question", questionAndAnswers);
        }

        [HttpPost]
        public ActionResult Question1(FormCollection collection)
        {
            var chosenAnswer = int.Parse(collection[0]);
            Session["Answers"] = new List<int> { chosenAnswer };

            return RedirectToAction("Question2");
        }

        public ActionResult Question2()
        {
            var questionAndAnswers = _questionsAndAnswersDataServices.GetQuestionAndAnswers(2);
            return View("Question",questionAndAnswers);
        }

        [HttpPost]
        public ActionResult Question2(FormCollection collection)
        {
            var chosenAnswer = int.Parse(collection[0]);
            AddAnswerToSession(chosenAnswer);
            return RedirectToAction("Question3");
        }

        public ActionResult Question3()
        {
            var questionAndAnswers = _questionsAndAnswersDataServices.GetQuestionAndAnswers(3);
            return View("Question", questionAndAnswers);
        }

        [HttpPost]
        public ActionResult Question3(FormCollection collection)
        {
            var chosenAnswer = int.Parse(collection[0]);
            AddAnswerToSession(chosenAnswer);
            return RedirectToAction("Question4");
        }

        public ActionResult Question4()
        {
            var questionAndAnswers = _questionsAndAnswersDataServices.GetQuestionAndAnswers(4);
            return View("Question", questionAndAnswers);
        }

        [HttpPost]
        public ActionResult Question4(FormCollection collection)
        {
            var chosenAnswer = int.Parse(collection[0]);
            AddAnswerToSession(chosenAnswer);
            return RedirectToAction("Question5");
        }

        public ActionResult Question5()
        {
            var questionAndAnswers = _questionsAndAnswersDataServices.GetQuestionAndAnswers(5);
            return View("Question", questionAndAnswers);
        }

        [HttpPost]
        public ActionResult Question5(FormCollection collection)
        {
            var chosenAnswer = int.Parse(collection[0]);
            AddAnswerToSession(chosenAnswer);
            return RedirectToAction("Question6");
        }

        public ActionResult Question6()
        {
            var questionAndAnswers = _questionsAndAnswersDataServices.GetQuestionAndAnswers(6);
            return View("Question", questionAndAnswers);
        }

        [HttpPost]
        public ActionResult Question6(FormCollection collection)
        {
            var chosenAnswer = int.Parse(collection[0]);
            AddAnswerToSession(chosenAnswer);
            return RedirectToAction("Question7");
        }

        public ActionResult Question7()
        {
            var questionAndAnswers = _questionsAndAnswersDataServices.GetQuestionAndAnswers(7);
            return View("Question", questionAndAnswers);
        }

        [HttpPost]
        public ActionResult Question7(FormCollection collection)
        {
            var chosenAnswer = int.Parse(collection[0]);
            AddAnswerToSession(chosenAnswer);
            return RedirectToAction("Question8");
        }

        public ActionResult Question8()
        {
            var questionAndAnswers = _questionsAndAnswersDataServices.GetQuestionAndAnswers(8);
            return View("Question", questionAndAnswers);
        }

        [HttpPost]
        public ActionResult Question8(FormCollection collection)
        {
            var chosenAnswer = int.Parse(collection[0]);
            AddAnswerToSession(chosenAnswer);
            return RedirectToAction("Question9");
        }

        public ActionResult Question9()
        {
            var questionAndAnswers = _questionsAndAnswersDataServices.GetQuestionAndAnswers(9);
            return View("Question", questionAndAnswers);
        }

        [HttpPost]
        public ActionResult Question9(FormCollection collection)
        {
            var chosenAnswer = int.Parse(collection[0]);
            AddAnswerToSession(chosenAnswer);
            return RedirectToAction("Question10");
        }

        public ActionResult Question10()
        {
            var questionAndAnswers = _questionsAndAnswersDataServices.GetQuestionAndAnswers(10);
            return View("Question", questionAndAnswers);
        }

        [HttpPost]
        public ActionResult Question10(FormCollection collection)
        {
            var chosenAnswer = int.Parse(collection[0]);
            AddAnswerToSession(chosenAnswer);
            return RedirectToAction("Result");
        }

        public ActionResult Result()
        {
            var chosenAnswers = Session["Answers"] as List<int>;
            if (chosenAnswers.Count != 10)
            {
                return RedirectToAction("Error");
            }

            return View();
        }

        private void AddAnswerToSession(int chosenAnswer)
        {
            var currentAnswer = Session["Answers"] as List<int>;
            currentAnswer.Add(chosenAnswer);
            Session["Answers"] = currentAnswer;
        }
    }
}
