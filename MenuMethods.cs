using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    public class MenuMethods
    {

        public static string GetName()
        {
            // Reads the users name to start the game. 
            Console.WriteLine("To start the game, please enter your name: ");

            var name = Console.ReadLine();

            return name;
        }

        public static void AdditionGame(string message)
        {
            // Generate random numbers for the problem given to the user.
            Random rnd = new Random();
            int number1 = rnd.Next(1, 9);
            int number2 = rnd.Next(1, 9);

            // Takes user input, and outputs a question with the operator choosen.
            int correctAnswer = 0;

            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("                     Here is your question! ");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine($"                            {number1} + {number2}");
            correctAnswer = Solve.Addition(number1, number2);

            Console.WriteLine("Enter your answer below! ");
            var userAnswerString = Console.ReadLine();
            var userAnswer = int.Parse(userAnswerString);

            if (userAnswer == correctAnswer)
            {
                Console.WriteLine("------------------------");
                Console.WriteLine("   Correct Answer! :-) ");
                Console.WriteLine("------------------------");
                Console.WriteLine("\n");

            }
            else if (userAnswer != correctAnswer)
            {
                Console.WriteLine("----------------------");
                Console.WriteLine("   Wrong Answer! :-( ");
                Console.WriteLine("----------------------");
                Console.WriteLine("\n");

            }

        }
        public static void SubtractionGame(string message)
        {
            // Generate random numbers for the problem given to the user.
            Random rnd = new Random();
            int number1 = rnd.Next(1, 9);
            int number2 = rnd.Next(1, 9);


            // Takes user input, and outputs a question with the operator choosen.
            int correctAnswer = 0;

            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("                     Here is your question! ");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine($"                            {number1} - {number2}");
            correctAnswer = Solve.Subtraction(number1, number2);

            Console.WriteLine("Enter your answer below! ");
            var userAnswerString = Console.ReadLine();
            var userAnswer = int.Parse(userAnswerString);


            if (userAnswer == correctAnswer)
            {
                Console.WriteLine("------------------------");
                Console.WriteLine("   Correct Answer! :-) ");
                Console.WriteLine("------------------------");
                Console.WriteLine("\n");

            }

            else if (userAnswer != correctAnswer)
            {
                Console.WriteLine("----------------------");
                Console.WriteLine("   Wrong Answer! :-( ");
                Console.WriteLine("----------------------");
                Console.WriteLine("\n");
            }


        }
        public static void MultiplicationGame(string message)
        {
            // Generate random numbers for the problem given to the user.
            Random rnd = new Random();
            int number1 = rnd.Next(1, 9);
            int number2 = rnd.Next(1, 9);

            // Takes user input, and outputs a question with the operator choosen.

            int correctAnswer = 0;
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("                     Here is your question! ");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine($"                            {number1} * {number2}");
            correctAnswer = Solve.Multiplication(number1, number2);

            Console.WriteLine("Enter your answer below! ");
            var userAnswerString = Console.ReadLine();
            var userAnswer = int.Parse(userAnswerString);


            if (userAnswer == correctAnswer)
            {
                Console.WriteLine("------------------------");
                Console.WriteLine("   Correct Answer! :-) ");
                Console.WriteLine("------------------------");
                Console.WriteLine("\n");

            }

            else if (userAnswer != correctAnswer)
            {
                Console.WriteLine("----------------------");
                Console.WriteLine("   Wrong Answer! :-( ");
                Console.WriteLine("----------------------");
                Console.WriteLine("\n");

            }

        }
        public static void DivisionGame(string message)
        {
            // Generate random numbers for the problem given to the user.
            Random rnd = new Random();
            int number1 = rnd.Next(1, 9);
            int number2 = rnd.Next(1, 9);


            // Takes user input, and outputs a question with the operator choosen.
            int correctAnswer = 0;

            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("                     Here is your question! ");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine($"                            {number1} / {number2}");
            correctAnswer = Solve.Division(number1, number2);

            Console.WriteLine("Enter your answer below! ");
            var userAnswerString = Console.ReadLine();
            var userAnswer = int.Parse(userAnswerString);


            if (userAnswer == correctAnswer)
            {
                Console.WriteLine("------------------------");
                Console.WriteLine("   Correct Answer! :-) ");
                Console.WriteLine("------------------------");
                Console.WriteLine("\n");


            }

            else if (userAnswer != correctAnswer)
            {
                Console.WriteLine("----------------------");
                Console.WriteLine("   Wrong Answer! :-( ");
                Console.WriteLine("----------------------");
                Console.WriteLine("\n");


            }

        }








    }
}
