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
            {"What do you care about the most?", "Power", "Freedom","Family" },
            {"You get a Mr. Meeseeks Box. What's the first thing you do?", "Improve myself as a person. eg: Become a better man/woman, reduce your golf game by 2 strokes, ...", "Improve the world. eg: End world hunger, global peace, ...","\"I'm Mr. Meeseeks! Look at me!\"" },
            {"You fuck something up. Big time. What do you do? ", "Apologize to those you wronged and try to make it better.", "Who cares? Everybody better deal with it. Can't be that important","Go to a different universe" },

            {"If you had a little ... Accident. What would you name it?", "Summer", "Morty Jr.","I don't name mistakes. Shoot it." },
            {"You come into contact with a highly skilled, dangerous assassin. What do you do? ", "Turn him in to the government's secret services, leading to his arrest.", "Ignore him. Not your problem.","Sell him specialized weapons for some extra money." },
            {"You get to meet the president of the United States of America. What do you do?", "Ask for a selfie.", "Salute and ask what you an do for him and your country.","Burp. Boring." },
            {"You just achieved a great thing. How do you celebrate?", "A big party with tons of people, plenty of booze and a cool DJ.", "Who am I kidding? I never accomplish anything remotely adequate!","With a hunt." },
            {"You want an object that can only be acquired in one place. It's extremely rare and potent. An interdimensional portal device is not an option. How do you get this through intergalactic customs?", "Declare it, pay taxes and probably be questioned, hoping it won't be confiscated by the feds.", "Fight my way through by force.","Smuggle it up your butt." }
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
