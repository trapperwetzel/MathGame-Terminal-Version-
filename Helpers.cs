using MathGameFinal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGameFinal
{
    internal class Helpers
    {
        // List used to track previous games the user plays. 
        static List<Game> games = new List<Game>();

        
        internal static void PrintGames()
        {
            Console.Clear();
            Console.WriteLine("Games History");
            Console.WriteLine("-----------------------------------");
            foreach(var game in games)
            {
                Console.WriteLine($"{game.Date} - {game.Type}: {game.Score}");
            }
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Press any key to return to Main Menu");
            Console.ReadLine();

        }

        //Adds to the list of games
        internal static void AddToHistory(int gameScore, string gameType)
        {

            games.Add(new Game
            {
                Date = DateTime.Now,
                Score = gameScore,
                Type = gameType
            });
            


        }

        internal static string ValidateResult(string result)
        {
            while (string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _))
            {
                Console.WriteLine("Your answer needs to be an integer. Try again. ");
                result = Console.ReadLine();
            }
            return result;
        }

    }
}
