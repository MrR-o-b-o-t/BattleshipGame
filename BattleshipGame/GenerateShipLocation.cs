using System;

namespace BattleshipGame
{
    internal class GenerateShipLocation
    {
        private static Random random = new Random();

        public static int[,] GenerateShipLocations()
        {
            int[,] shipBoard = new int[10, 10];
            int shipSize = 5;

            int shipLocationX = random.Next(10);
            int shipLocationY = random.Next(10);

            int direction = random.Next(4); 

            for (int i = 0; i < shipSize; i++)
            {
                if (shipLocationX < 0 || shipLocationX >= 10 || shipLocationY < 0 || shipLocationY >= 10 || shipBoard[shipLocationX, shipLocationY] != 0)
                {
                    shipLocationX = random.Next(10);
                    shipLocationY = random.Next(10);
                    direction = random.Next(4);
                    i = -1; 
                    continue;
                }

                shipBoard[shipLocationX, shipLocationY] = 1;

                if (direction == 0)
                    shipLocationX--;
                else if (direction == 1)
                    shipLocationY++;
                else if (direction == 2)
                    shipLocationX++;
                else if (direction == 3)
                    shipLocationY--;
            }

            return shipBoard;
        }
    }
}
