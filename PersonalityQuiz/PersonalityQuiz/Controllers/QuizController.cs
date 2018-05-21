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

            return View(questionAndAnswers);
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

            return View("Question1",questionAndAnswers);
        }

        [HttpPost]
        public ActionResult Question2(FormCollection collection)
        {
            var chosenAnswer = int.Parse(collection[0]);


            return RedirectToAction("Question3");
        }

        {
            var currentAnswer = Session["Answers"] as List<int>;
            currentAnswer.Add(chosenAnswer);
            Session["Answers"] = currentAnswer;
        }
    }
}
