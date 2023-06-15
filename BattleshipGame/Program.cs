Console.WriteLine("*********************************************************************************************************************");
Console.WriteLine("The Game is simple, you will be prompted to select a point on a 10 x 10 grid.");
Console.WriteLine("The point is made up of an X-value and a Y-value that represent one square of the grid... Please see below.");
Console.WriteLine();
Console.WriteLine();

PrintGameBoard();

Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Once the point is selected you will be prompted with a hit or miss.");
Console.WriteLine("You will be given a total of 8 guesses. If you do not destroy the enemy vessel...");
Console.WriteLine("You are porbably fit for the 1588 Spanish Armada and lose the game.");
Console.WriteLine("However, if you annihalate the enemy, which takes up 5 grid spaces, you win!.");
Console.WriteLine("After which you can gloat to your firends and family, and garner the respect of your peers.");

Console.WriteLine("*********************************************************************************************************************");

void PrintGameBoard()
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

Console.ReadKey();