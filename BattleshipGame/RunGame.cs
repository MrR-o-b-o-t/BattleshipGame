using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipGame
{
    internal class RunGame
    {
        public void RunNewGame()
        {
            var shots = 0;
            var hits = 0;
            var misses = 0;
            var userX = "";
            var userY = "";

            Console.WriteLine($"Shots Remaining = {shots} Hits = {hits} Misses = {misses}");
            for (int i = 10; i >= 0; i--)
            {
                if (i == 10)
                {
                    Console.WriteLine($"{i} -  -  -  -  -  -  -  -  -  -");
                }
                else
                {
                    Console.WriteLine($"{i}  -  -  -  -  -  -  -  -  -  -");
                }

            }

            Console.WriteLine($"0  1  2  3  4  5  6  7  8  9  10");
            Console.WriteLine();
            Console.Write("(X-axis) - Select a spot [1-10] to fire on: ");
            userX = Console.ReadLine();
            Console.Write("(Y-axis) - Select a spot [1-10] to fire on: ");
            userY = Console.ReadLine();
        }
    }
}
