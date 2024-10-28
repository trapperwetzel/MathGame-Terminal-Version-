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
            Console.Clear();
            Console.WriteLine($"{message}");
            Random rnd = new Random();
            var score = 0;
            int number1;
            int number2;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine($"{message}");
               

                number1 = rnd.Next(1, 9);
                number2 = rnd.Next(1, 9);


                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine("                     Here is your question! ");
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine($"                            {number1} + {number2}");
                int correctAnswer = Solve.Addition(number1, number2);

                Console.WriteLine("Enter your answer below! ");
                var userAnswer = int.Parse(Console.ReadLine());


                if (userAnswer == correctAnswer)
                {
                    Console.WriteLine("------------------------");
                    Console.WriteLine("   Correct Answer! :-) ");
                    Console.WriteLine("------------------------");
                    score++;
                    Console.WriteLine("Please enter any key for your next question");
                    Console.ReadLine();
                }
                else if (userAnswer != correctAnswer)
                {
                    Console.WriteLine("----------------------");
                    Console.WriteLine("   Wrong Answer! :-( ");
                    Console.WriteLine("----------------------");
                    Console.WriteLine("Please enter any key for your next question");
                    Console.ReadLine();
                }

                if (i == 4)
                {
                    Console.Clear();
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine($"Game Over! Your score is {score}");
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("Press any key to go back to the main menu. :)");
                    Console.ReadLine();
                }

            }

        }
        public static void SubtractionGame(string message)
        {
            Console.Clear();
            Console.WriteLine($"{message}");
            Random rnd = new Random();
            var score = 0;
            int number1;
            int number2;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine($"{message}");

                number1 = rnd.Next(1, 9);
                number2 = rnd.Next(1, 9);


                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine("                     Here is your question! ");
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine($"                            {number1} - {number2}");
                int correctAnswer = Solve.Subtraction(number1, number2);

                Console.WriteLine("Enter your answer below! ");
                var userAnswer = int.Parse(Console.ReadLine());


                if (userAnswer == correctAnswer)
                {
                    Console.WriteLine("------------------------");
                    Console.WriteLine("   Correct Answer! :-) ");
                    Console.WriteLine("------------------------");
                    score++;
                    Console.WriteLine("Please enter any key for your next question");
                    Console.ReadLine();
                }
                else if (userAnswer != correctAnswer)
                {
                    Console.WriteLine("----------------------");
                    Console.WriteLine("   Wrong Answer! :-( ");
                    Console.WriteLine("----------------------");
                    Console.WriteLine("Please enter any key for your next question");
                    Console.ReadLine();
                }

                if (i == 4)
                {
                    Console.Clear();
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine($"Game Over! Your score is {score}");
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("Press any key to go back to the main menu. :)");
                    Console.ReadLine();
                }
            }
        }
        public static void MultiplicationGame(string message)
        {
            Console.Clear();
            Console.WriteLine($"{message}");
            Random rnd = new Random();
            var score = 0;
            int number1;
            int number2;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine($"{message}");

                number1 = rnd.Next(1, 9);
                number2 = rnd.Next(1, 9);


                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine("                     Here is your question! ");
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine($"                            {number1} * {number2}");
                int correctAnswer = Solve.Multiplication(number1, number2);

                Console.WriteLine("Enter your answer below! ");
                var userAnswer = int.Parse(Console.ReadLine());


                if (userAnswer == correctAnswer)
                {
                    Console.WriteLine("------------------------");
                    Console.WriteLine("   Correct Answer! :-) ");
                    Console.WriteLine("------------------------");
                    score++;
                    Console.WriteLine("Please enter any key for your next question");
                    Console.ReadLine();
                }
                else if (userAnswer != correctAnswer)
                {
                    Console.WriteLine("----------------------");
                    Console.WriteLine("   Wrong Answer! :-( ");
                    Console.WriteLine("----------------------");
                    Console.WriteLine("Please enter any key for your next question");
                    Console.ReadLine();
                }
                if (i == 4)
                {
                    Console.Clear();
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine($"Game Over! Your score is {score}");
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("Press any key to go back to the main menu. :)");
                    Console.ReadLine();
                }


            }


        }
        public static void DivisionGame(string message) 
        {
            Console.Clear();
            Console.WriteLine($"{message}");

            Random rnd = new Random();
            var score = 0;
            int number1;
            int number2;

            // Our game will be different for division:
            // Our random numbers are going to be setup so that the first num is always the biggest number
            // This is so we have questions that actually are challenging and make sense for division.

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine($"{message}");

                number1 = rnd.Next(10, 99);
                number2 = rnd.Next(1, 9);


                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine("                     Here is your question! ");
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine($"                            {number1} / {number2}");
                int correctAnswer = Solve.Division(number1, number2);

                Console.WriteLine("Enter your answer below! ");
                var userAnswer = int.Parse(Console.ReadLine());


                if (userAnswer == correctAnswer)
                {
                    Console.WriteLine("------------------------");
                    Console.WriteLine("   Correct Answer! :-) ");
                    Console.WriteLine("------------------------");
                    score++;
                    Console.WriteLine("Please enter any key for your next question");
                    Console.ReadLine();
                }
                else if (userAnswer != correctAnswer)
                {
                    Console.WriteLine("----------------------");
                    Console.WriteLine("   Wrong Answer! :-( ");
                    Console.WriteLine("----------------------");
                    Console.WriteLine("Please enter any key for your next question");
                    Console.ReadLine();
                }

                if (i == 4)
                {
                    Console.Clear();
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine($"Game Over! Your score is {score}");
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("Press any key to go back to the main menu. :)");
                    Console.ReadLine();
                }


            }


        }
    }
}

