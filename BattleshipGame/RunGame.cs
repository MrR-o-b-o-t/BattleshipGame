using System;
using System.Reflection.Metadata.Ecma335;

namespace BattleshipGame
{
    internal class RunGame
    {
        public void RunNewGame()
        {
            bool restart = true;
            bool continueGame = true;

            while (restart)
            {
                int[,] shipBoard = GenerateShipLocation.GenerateShipLocations();

                int shots = 8;
                int hits = 0;
                int misses = 0;
                var userX = "";
                var userY = "";
                int number;

                int[,] gameBoard = new int[10, 10];

                while (shots > 0 && hits < 5)
                {

                    Console.WriteLine($"Shots Remaining = {shots} Hits = {hits} Misses = {misses}");

                    PrintGameBoard printGameBoard = new PrintGameBoard();
                    printGameBoard.PrintNewGameBoard(gameBoard);
                    Console.WriteLine();
                    Console.Write("(X-axis) - Select a spot [1-10] to fire on: ");
                    userX = Console.ReadLine();

                    while (!int.TryParse(userX, out number) || number < 1 || number > 10)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        userX = Console.ReadLine();
                        continue;
                    }

                    var userXNum = int.Parse(userX);

                    Console.Write("(Y-axis) - Select a spot [1-10] to fire on: ");
                    userY = Console.ReadLine();

                    while (!int.TryParse(userY, out number) || number < 1 || number > 10)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        userY = Console.ReadLine();
                        continue;
                    }

                    var userYNum = int.Parse(userY);

                    bool isHit = isMatch(userXNum, userYNum, shipBoard);
                    shots--;

                    if (isHit)
                    {
                        userYNum--;
                        userXNum--;
                        hits++;
                        gameBoard[userYNum, userXNum] = 1;
                    }
                    else
                    {
                        misses++;
                        gameBoard[userYNum - 1, userXNum - 1] = -1;
                    }

                    Console.Clear();

                    if (shots <= 4 && hits <= 2 && continueGame)
                    {
                        Console.WriteLine("The odds aren't in your favor champ. It's impossible to win.");
                        Console.WriteLine("Do you want to finish the game out? (Y/N)");
                        var input = Console.ReadLine().ToLower();

                        if(input == "y")
                        {
                            continueGame = false;
                            Console.Clear();
                        } else
                        {
                            restart = false;
                            break;
                        }
                    }

                }

                bool isMatch(int userXNum, int userYNum, int[,] shipBoard)
                {
                    if (shipBoard[userYNum - 1, userXNum - 1] == 1)
                    {
                        Console.WriteLine("Hit!");
                        Console.WriteLine();
                        Console.WriteLine("Press Enter to resume!");
                        Console.ReadLine();
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Miss!");
                        Console.WriteLine();
                        Console.WriteLine("Press Enter to resume!");
                        Console.ReadLine();
                        return false;
                    }
                }

                if (hits == 5)
                {
                    Console.WriteLine("You win! Press any key to continue.");
                    Console.ReadLine();
                }
                else if (shots == 0)
                {
                    Console.WriteLine("You lost!");
                    Console.ReadLine();
                    restart = false;
                }
            }
        }
    }
}
