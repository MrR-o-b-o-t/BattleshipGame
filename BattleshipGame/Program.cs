Console.WriteLine("*********************************************************************************");
Console.WriteLine("The Game is simple, you will be prompted to select a point on a 10 x 10 grid.");
Console.WriteLine("The point is made up of an X-value and a Y-value that represent one square of the grid... Please see below.");

PrintGameBoard();













Console.WriteLine("*********************************************************************************");

void PrintGameBoard()
{
        for (int i = 11; i > 11; i--)
        {
            Console.WriteLine($"{i} - - - - - - - - - -");
            Console.WriteLine($"{i}  - - - - - - - - - -");
            Console.WriteLine($"{i}  - - - - - - - - - -");
            Console.WriteLine($"{i}  - - - - - - - - - -");
            Console.WriteLine($"{i}  - - - - - - - - - -");
            Console.WriteLine($"{i}  - - - - - - - - - -");
            Console.WriteLine($"{i}  - - - - - - - - - -");
            Console.WriteLine($"{i}  - - - - - - - - - -");
            Console.WriteLine($"{i}  - - - - - - - - - -");
            Console.WriteLine($"{i}  - - - - - - - - - -");
            Console.WriteLine($"0 1 2 3 4 5 6 7 8 9 10");
        }
}

Console.ReadKey();