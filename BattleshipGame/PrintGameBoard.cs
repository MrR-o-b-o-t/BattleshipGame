using System;

namespace BattleshipGame
{
    internal class PrintGameBoard
    {
public void PrintNewGameBoard(int[,] board)
{

    for (int row = 9; row >= 0; row--)
    {
        Console.Write((row + 1).ToString().PadRight(2));

        for (int col = 0; col < 10; col++)
        {
            int cellValue = board[row, col];
            char displayChar;

            switch (cellValue)
            {
                case 0:
                    displayChar = '-';
                    break;
                case 1:
                    displayChar = 'X';
                    break;
                case -1:
                    displayChar = 'O';
                    break;
                default:
                    displayChar = '-';
                    break;
            }

            Console.Write($" {displayChar} ");
        }

        Console.WriteLine("");
    }

    Console.WriteLine("0  1  2  3  4  5  6  7  8  9  10");
}
    }
}
