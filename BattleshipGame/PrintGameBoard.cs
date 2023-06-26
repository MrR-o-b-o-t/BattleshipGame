using System;

namespace BattleshipGame
{
    internal class PrintGameBoard
    {
        public void PrintNewGameBoard(int[,] board)
        {
            var myLabel = 10;

            for (int row = 0; row < 10; row++)
            {
                Console.Write((myLabel));
                myLabel--;

                for (int col = 0; col < 10; col++)
                {
                    if (board[row, col] == 1)
                    {
                        Console.Write(" X ");
                    }
                    else if (board[row, col] == -1)
                    {
                        Console.Write(" O ");
                    }
                    else
                    {
                        Console.Write(" - ");
                    }
                }

                Console.WriteLine();
            }
            Console.WriteLine("0  1  2  3  4  5  6  7  8  9  10");
        }
    }
}
