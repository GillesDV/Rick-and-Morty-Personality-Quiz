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
            string chosenAnswer = collection[0];
            return RedirectToAction("Question2");
        }

        // GET: Quiz/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Quiz/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Quiz/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Quiz/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Quiz/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Quiz/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Quiz/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
