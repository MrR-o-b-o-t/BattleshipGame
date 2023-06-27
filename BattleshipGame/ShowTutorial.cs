using System;

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
            int[,] gameBoard = new int[10, 10]; 
            printGameBoard.PrintNewGameBoard(gameBoard);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Once the point is selected you will be prompted with a hit or miss.");
            Console.WriteLine("You will be given a total of 8 guesses. If you do not destroy the enemy vessel...");
            Console.WriteLine("You are probably fit for the 1588 Spanish Armada and lose the game.");
            Console.WriteLine("However, if you annihilate the enemy, which takes up 5 grid spaces, you win!.");
            Console.WriteLine("After which you can gloat to your friends and family, and garner the respect of your peers.");

            Console.WriteLine("*********************************************************************************************************************");
            Console.WriteLine("");
            Console.WriteLine("Press any key to fire up the boilers and ship off!");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
