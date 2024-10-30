using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGameFinal
{
    public class MainGame
    {

        public static void Menu(string Name, DateTime Date)
        {
            // Main Menu 

            Console.WriteLine($"Hello {Name}, The date is {Date}, Thank you so much for playing MathGame :-) ");
            Console.WriteLine("\n");

            
            // If user presses yes to another game, or is just starting the game, the isGameOn bool will be true.
            // This bool is used to loop and have multiple games. 
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
                        Helpers.PrintGames();
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

