using System;

namespace _02.Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] territory = new char[n, n];

            int snakeRow = 0;
            int snakeCol = 0;

            int[] burrowOne = new int[2];
            int[] burrowTwo = new int[2];
            int countBurow = 0;

            for (int row = 0; row < n; row++)
            {
                char[] currentRow = Console.ReadLine().ToCharArray();

                for (int col = 0; col < n; col++)
                {
                    territory[row, col] = currentRow[col];

                    if (territory[row, col] == 'S')
                    {
                        snakeRow = row;
                        snakeCol = col;
                    }

                    if (countBurow == 1 && territory[row, col] == 'B')
                    {
                        burrowTwo[0] = row;
                        burrowTwo[1] = col;
                    }
                    if (territory[row, col] == 'B')
                    {
                        countBurow++;
                        burrowOne[0] = row;
                        burrowOne[1] = col;
                    }
                }
            }

            int foodQuantity = 0;
            bool isOut = false;
            bool theSnakeIsEaten = false;

            while (true)
            {
                string command = Console.ReadLine();
                territory[snakeRow, snakeCol] = '.';

                if (command == "up")
                {
                    snakeRow--;
                }
                else if (command == "down")
                {
                    snakeRow++;
                }
                else if (command == "left")
                {
                    snakeCol--;
                }
                else if (command == "right")
                {
                    snakeCol++;
                }

                if (IsOut(territory, snakeRow, snakeCol))
                {
                    isOut = true;
                    break;
                }

                if (territory[snakeRow, snakeCol] == '*')
                {
                    //territory[snakeRow, snakeCol] = '.';
                    foodQuantity++;

                    if (foodQuantity >= 10)
                    {
                        territory[snakeRow, snakeCol] = 'S';
                        theSnakeIsEaten = true;
                        break;
                    }
                }
                else if (territory[snakeRow, snakeCol] == 'B')
                {
                    territory[snakeRow, snakeCol] = '.';
                    if (snakeRow == burrowOne[0] && snakeCol == burrowOne[1])
                    {
                        snakeRow = burrowTwo[0];
                        snakeCol = burrowTwo[1];
                    }
                    else
                    {
                        snakeRow = burrowOne[0];
                        snakeCol = burrowOne[1];
                    }
                    //territory[snakeRow, snakeCol] = '.';

                }

                //territory[snakeRow, snakeCol] = '.';
            }

            if (isOut)
            {
                Console.WriteLine("Game over!");
            }

            if (theSnakeIsEaten)
            {
                Console.WriteLine($"You won! You fed the snake.");
            }

            Console.WriteLine($"Food eaten: {foodQuantity}");

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(territory[row, col]);
                }
                Console.WriteLine();
            }
        }

        public static bool IsOut(char[,] matrix, int row, int col)
        {
            return row < 0 || row >= matrix.GetLength(0)
                  || col < 0 || col >= matrix.GetLength(1);
        }

        public static int MooveRow(int row, string direction)
        {
            if (direction == "up")
            {
                return row - 1;
            }
            if (direction == "down")
            {
                return row + 1;
            }

            return row;
        }

        public static int MooveCol(int col, string direction)
        {
            if (direction == "left")
            {
                return col - 1;
            }
            if (direction == "right")
            {
                return col + 1;
            }

            return col;
        }

        public static bool IsValidPosition(int row, int col, int rows, int cows)
        {
            if (row < 0 || row >= rows)
            {
                return false;
            }
            if (col < 0 || col >= cows)
            {
                return false;
            }
            return true;
        }
    }
}
