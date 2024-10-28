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

            switch (userchoice.Trim().ToLower())
            {
                case "a":
                    MenuMethods.AdditionGame("Addition Game Selected");
                    break;


                case "s":
                    MenuMethods.SubtractionGame("Subtraction Game Selected");
                    break;


                case "m":
                    MenuMethods.MultiplicationGame("Multiplication Game Selected");
                    break;


                case "d":
                    MenuMethods.DivisionGame("Division Game Selected");
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

           

         
          

            
            
        }
        
    }
}
