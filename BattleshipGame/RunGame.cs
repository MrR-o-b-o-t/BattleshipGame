using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipGame
{
    internal class RunGame
    {
        public void PrintGameBoard()
        {
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
        }
    }
}
