using BattleshipGame;

ShowTutorial showTutorial = new ShowTutorial();
PrintGameBoard printGameBoard = new PrintGameBoard();
RunGame runGame = new RunGame();

showTutorial.ShowTutorialScreen();

Console.WriteLine("Do you want to play battleship? (Y or N)");

var playGame = Console.ReadLine();
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
        Console.ReadKey();
    }
}

int GenerateBattleshipLocation()
{
    Random battleship = new Random();
    var battleshipX = battleship.Next(10);
    var battleshipY = 0;

    if(battleshipX == 5)
    {
        battleshipY = battleshipX++;
    }

    Console.WriteLine(battleshipY);
}

Console.WriteLine("Program end");
Console.ReadKey();

