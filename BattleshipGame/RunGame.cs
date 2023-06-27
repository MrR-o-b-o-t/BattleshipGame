using System;

namespace BattleshipGame
{
    internal class RunGame
    {
        public void RunNewGame()
        {
            int[,] shipBoard = GenerateShipLocation.GenerateShipLocations();

            int shots = 8;
            int hits = 0;
            int misses = 0;
            var userX = "";
            var userY = "";

            int[,] gameBoard = new int[10, 10];

            while (shots > 0 && hits < 5)
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

                bool isHit = isMatch(userXNum, userYNum, shipBoard);
                shots--;

                if (isHit)
                {
                    userYNum--;
                    userXNum--;
                    hits++;
                    gameBoard[userYNum, userXNum] = 1; // Update gameBoard with hit
                }
                else
                {
                    misses++;
                    gameBoard[userYNum - 1, userXNum - 1] = -1; // Update gameBoard with miss
                }

                Console.Clear();
            }

            // Method to check for hit or miss
            bool isMatch(int userXNum, int userYNum, int[,] shipBoard)
            {
                if (shipBoard[userYNum - 1, userXNum - 1] == 1)
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

            if (hits == 5)
            {
                Console.WriteLine("You win! Press any key to continue.");
                Console.ReadKey();
            }
        }
    }
}
