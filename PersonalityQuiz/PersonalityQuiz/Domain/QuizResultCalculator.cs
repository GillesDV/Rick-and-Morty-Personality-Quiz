﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalityQuiz.Domain
{
    public class QuizResultCalculator
    {
        private static int _rickCounter = 0;
        private static int _mortyCounter = 0;
        private static int _jerryCounter = 0;
        private static int _bethCounter = 0;
        private static int _summerCounter = 0;

        private static int _mrMeeseeksCounter = 0;


        public static string CalculateResult(List<int> allAnswers)
        {
            switch (allAnswers[0])
            {
                case 1:
                    _rickCounter++;
                    _mortyCounter++;
                    _jerryCounter++;
                    break;
                case 2:
                    _summerCounter++;
                    _bethCounter++;
                    break;
                case 3:
                    _mrMeeseeksCounter++;
                    break;
            }
            switch (allAnswers[1])
            {
                case 1:
                    _jerryCounter++;
                    _summerCounter++;
                    break;
                case 2:
                    _summerCounter++;
                    _bethCounter++;
                    break;
                case 3:
                    _rickCounter++;
                    _mortyCounter++;
                    break;
            }
            switch (allAnswers[2])
            {
                case 1:

                    break;
                case 2:
                    _rickCounter++;
                    break;
                case 3:
                    _rickCounter++;
                    _mortyCounter++;
                    _bethCounter++;
                    _jerryCounter++;
                    break;
            }
            switch (allAnswers[3])
            {
                case 1:
                    _summerCounter++;
                    _bethCounter++;
                    _jerryCounter++;
                    break;
                case 2:
                    break;
                case 3:
                    _mrMeeseeksCounter += 20;
                    break;
            }
            switch (allAnswers[4])
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
            }


            switch (allAnswers[5])
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
            }
            switch (allAnswers[6])
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
            }
            switch (allAnswers[7])
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
            }
            switch (allAnswers[8])
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
            }
            switch (allAnswers[9])
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
            }


            return null;
        }

    }
}
