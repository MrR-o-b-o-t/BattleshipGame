using System;

namespace BattleshipGame
{
    internal class RunGame
    {
        public void RunNewGame()
        {
            int shipLocationX = 10;
            int shipLocationY = 5;

            var shots = 8;
            var hits = 0;
            var misses = 0;
            var userX = "";
            var userY = "";

            int[,] gameBoard = new int[10, 10];

            while (shots > 0 && hits < 2)
            {
                Console.WriteLine($"Shots Remaining = {shots} Hits = {hits} Misses = {misses}");

                PrintGameBoard printGameBoard = new PrintGameBoard();
                printGameBoard.PrintNewGameBoard(gameBoard);

                Console.WriteLine();
                Console.Write("(X-axis) - Select a spot [1-10] to fire on: ");
                userX = Console.ReadLine();
                var userXNum = int.Parse(userX);

                Console.Write("(Y-axis) - Select a spot [1-10] to fire on: ");
                userY = Console.ReadLine();
                var userYNum = int.Parse(userY);

                bool isHit = isMatch(userXNum, userYNum, shipLocationX, shipLocationY);
                shots--;

                if (isHit)
                {
                    hits++;
                    gameBoard[userYNum, userXNum] = 1;
                }
                else
                {
                    misses++;
                    gameBoard[userYNum, userXNum] = -1;
                }

                Console.Clear();
            }

            // Method to check for hit or miss
            bool isMatch(int userXNum, int userYNum, int shipLocationX, int shipLocationY)
            {
                if (userXNum == shipLocationX && userYNum == shipLocationY)
                {
                    Console.WriteLine("Hit!");
                    Console.WriteLine();
                    Console.WriteLine("Press Enter to resume!");
                    Console.ReadKey();
                    return true;
                }
                else
                {
                    Console.WriteLine("Miss!");
                    Console.WriteLine();
                    Console.WriteLine("Press Enter to resume!");
                    Console.ReadKey();
                    return false;
                }
            }

            if (hits == 2)
            {
                Console.WriteLine("You win! Press any key to continue.");
                Console.ReadKey();
            }
        }
    }
}
