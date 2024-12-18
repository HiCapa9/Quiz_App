﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_App
{
    internal class Quiz
    {
        private Question[] questions;

        public Quiz(Question[] questions)
        {
            this.questions = questions;
        }

        public void StartQuiz() {
            Console.WriteLine("Welcome to the quiz");
            int questionNumber = 1;

            foreach (Question question in questions){
                Console.WriteLine($"Question {questionNumber++}");
                DisplayQuestion(question);
                int userChoice = GetUserChoice();

                if (question.IsAnswerCorrect(userChoice))
                {
                    Console.WriteLine("Correct");
                }
                else {
                    Console.WriteLine($"Wrong! The correct answer was: {question.Answers[question.CorrectAnswerIndex]}");
                }
            }

        }

        private void DisplayQuestion(Question question) {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(question.QuestionText);
            Console.ResetColor();

            for (int i = 0; i < question.Answers.Length; i++) {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("    ");
                Console.Write(i + 1);
                Console.ResetColor();
                Console.WriteLine($". {question.Answers[i]}");
            }


        }

        private int GetUserChoice() {
            Console.WriteLine("Your answer (number): ");
            string input = Console.ReadLine();
            int choice = 0;
            while (!int.TryParse(input, out choice) || choice < 1 || choice > 4)
            {
                Console.WriteLine("Invalid choice. Please enter a numvber between 1 and 4: ");
                input = Console.ReadLine();
            }
            return choice - 1;

        }


    }
}
