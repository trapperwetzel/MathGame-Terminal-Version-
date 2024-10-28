using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    public class MainGame
    {

        public static void Menu(string Name, DateTime Date)
        {
            // Menu
            Console.WriteLine($"Hello {Name}, The date is {Date}, Thank you so much for playing MathGame :-) ");
            Console.WriteLine("\n");

            bool isGameOn = true;

            do
            {
                Console.Clear();
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine(" Please enter your choice out of the operators given below ");
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine("\n" +
                    "V - Your Games\n" +
                    "A - Addition\n" +
                    "S - Subtraction\n" +
                    "M - Multiplication\n" +
                    "D - Division\n" +
                    "Q - Quit Game\n");


                // Reads the users input, puts it in a variable.
                var userchoice = Console.ReadLine();

                switch (userchoice.Trim().ToLower())
                {
                    case "v":
                        Helpers.GetGames();
                        break;

                    case "a":
                        MenuMethods.AdditionGame("Addition Game");
                        break;


                    case "s":
                        MenuMethods.SubtractionGame("Subtraction Game");
                        break;


                    case "m":
                        MenuMethods.MultiplicationGame("Multiplication Game");
                        break;

                    case "d":
                        MenuMethods.DivisionGame("Division Game");
                        break;
                    case "q":
                        Console.WriteLine("Goodbye! Thank you for playing.");
                        isGameOn = false;
                        Environment.Exit(1);
                        break;
                    
                }
               
            }
            while (isGameOn);
        }
        
    }
}

