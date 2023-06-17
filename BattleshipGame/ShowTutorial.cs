using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipGame
{
    internal class ShowTutorial
    {
        public void ShowTutorialScreen()
        {
            Console.WriteLine("*********************************************************************************************************************");
            Console.WriteLine("The Game is simple, you will be prompted to select a point on a 10 x 10 grid.");
            Console.WriteLine("The point is made up of an X-value and a Y-value that represent one square of the grid... Please see below.");
            Console.WriteLine();
            Console.WriteLine();

            PrintGameBoard printGameBoard = new PrintGameBoard();
            printGameBoard.PrintNewGameBoard();

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Once the point is selected you will be prompted with a hit or miss.");
            Console.WriteLine("You will be given a total of 8 guesses. If you do not destroy the enemy vessel...");
            Console.WriteLine("You are porbably fit for the 1588 Spanish Armada and lose the game.");
            Console.WriteLine("However, if you annihalate the enemy, which takes up 5 grid spaces, you win!.");
            Console.WriteLine("After which you can gloat to your firends and family, and garner the respect of your peers.");

            Console.WriteLine("*********************************************************************************************************************");
            Console.WriteLine("");
            Console.WriteLine("Press any key to fire up the boilers and ship off!");
            Console.ReadKey();
        }
    }
}
