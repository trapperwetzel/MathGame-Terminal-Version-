using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    public class MainGame
    {
        public static void PlayGame()
        { // Main Code

            // Reads the users name to start the game. 
            Console.WriteLine("To start the game, please enter your name: ");

            var name = Console.ReadLine();
            var date = DateTime.UtcNow;
            //
            Console.WriteLine($"Hello {name}, The date is {date}, Thank you so much for playing MathGame :-) ");
            Console.WriteLine("\n");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine(" Please enter your choice out of the operators given below ");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("\n" +
                "A - Addition\n" +
                "S - Subtraction\n" +
                "M - Multiplication\n" +
                "D - Division\n" +
                "Q - Quit Game\n");


            // Reads the users input, puts it in a variable.
            var userchoice = Console.ReadLine();

            // Generate random numbers for the problem given to the user.
            Random rnd = new Random();
            int number1 = rnd.Next(1, 9);
            int number2 = rnd.Next(1, 9);



            // Takes user input, and outputs a question with the operator choosen.
            int correctAnswer = 0;
            switch (userchoice.Trim().ToLower())
            {
                case "a":
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine("                     Here is your question! ");
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine($"                            {number1} + {number2}");
                    correctAnswer = Solve.Addition(number1, number2);
                    break;


                case "s":
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine("                     Here is your question! ");
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine($"                            {number1} - {number2}");
                    correctAnswer = Solve.Subtraction(number1, number2);
                    break;


                case "m":
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine("                     Here is your question! ");
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine($"                            {number1} * {number2}");
                    correctAnswer = Solve.Multiplication(number1, number2);
                    break;


                case "d":
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine("                     Here is your question! ");
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine($"                            {number1} / {number2}");
                    correctAnswer = Solve.Division(number1, number2);
                    break;
                case "q":
                    Console.WriteLine("Goodbye! Thank you for playing.");
                    Environment.Exit(1);
                    break;
                default:
                    Console.WriteLine("Invalid Input:");
                    Environment.Exit(1);
                    break;
            }

            Console.WriteLine("Enter your answer below! ");
            var userAnswerString = Console.ReadLine();
            var userAnswer = int.Parse(userAnswerString);

         
            if (userAnswer == correctAnswer)
            {
                Console.WriteLine("------------------------");
                Console.WriteLine("   Correct Answer! :-) ");
                Console.WriteLine("------------------------");
                Console.WriteLine("\n");
                Console.WriteLine("Would you like to play again? ");
                
                PlayGame();
            }

            else if (userAnswer != correctAnswer)
            {
                Console.WriteLine("----------------------");
                Console.WriteLine("   Wrong Answer! :-( ");
                Console.WriteLine("----------------------");
                Console.WriteLine("\n");
                Console.WriteLine("Would you like to play again? ");
                
                PlayGame();
            }
            
        }
        
    }
}
