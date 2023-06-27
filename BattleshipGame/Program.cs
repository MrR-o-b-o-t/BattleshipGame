using System;

namespace BattleshipGame
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowTutorial showTutorial = new ShowTutorial();
            PrintGameBoard printGameBoard = new PrintGameBoard();
            RunGame runGame = new RunGame();

            showTutorial.ShowTutorialScreen();

            Console.WriteLine("Do you want to play battleship? (Y or N)");

            var playGame = Console.ReadLine().ToLower();
            while (playGame == "y")
            {
                if (playGame == "y")
                {
                    Console.Clear();
                    Console.WriteLine("Do you want to a quick tutorial? (Y or N)");
                    var playTutorial = Console.ReadLine();
                    if (playTutorial == "y")
                    {
                        Console.Clear();
                        showTutorial.ShowTutorialScreen();
                    }
                    else if (playTutorial == "n")
                    {
                        Console.Clear();
                        runGame.RunNewGame();
                        Console.Clear();
                        Console.WriteLine("Do you want to play again? (Y or N)");
                        playGame = Console.ReadLine().ToLower();
                    }
                }
            }

            Console.Clear();
            Console.WriteLine("Thanks for playing! Press any key to close.");
            Console.ReadKey();
        }
    }
}
