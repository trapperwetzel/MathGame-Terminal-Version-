using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    internal class Helpers
    {
        static List<string> games = new List<string>();

        internal static void GetGames()
        {
            Console.Clear();
            Console.WriteLine("Games History");
            Console.WriteLine("-----------------------------------");
            foreach(var game in games)
            {
                Console.WriteLine(game);
            }
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Press any key to return to Main Menu");
            Console.ReadLine();

        }

        internal static void AddToHistory(int gameScore, string gameType)
        {
            games.Add($"{DateTime.Now} - {gameType}: {gameScore} pts");

        }



    }
}
