using System;
using System.Linq;

namespace _9._Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimentions = int.Parse(Console.ReadLine());

            string[] commands = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            int rows = dimentions;
            int cols = dimentions;

            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] numbers = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }

            int[] startPositions = FindStartPosition(matrix);

            int rowStart = startPositions[0];
            int colStart = startPositions[1];

            int countCoals = 0;
            int numberCoals = GetNumberCoals(matrix); /*matrix.Cast<char>().Where(x => x ='c').Select(x => x='c').Count();*/

            for (int i = 0; i < commands.Length; i++)
            {
                string dimention = commands[i];

                switch (dimention)
                {
                    case "up":

                        if (IsValid(matrix, rowStart - 1, colStart))
                        {
                            char currentCell = matrix[rowStart - 1, colStart];
                            if (currentCell == 'c')
                            {
                                matrix[rowStart - 1, colStart] = '*';
                                countCoals++;

                                if (countCoals == numberCoals)
                                {
                                    Console.WriteLine($"You collected all coals! ({rowStart - 1}, {colStart})");
                                    return;
                                }
                            }
                            else if (currentCell == 'e')
                            {
                                Console.WriteLine($"Game over! ({rowStart - 1}, {colStart})");
                                return;
                            }
                            else if (currentCell == '*')
                            {
                                rowStart -= 1;
                                colStart = colStart;
                                continue;
                            }
                            rowStart -= 1;
                            colStart = colStart;
                        }
                        
                        break;
                    case "down":
                        if (IsValid(matrix, rowStart + 1, colStart))
                        {
                            char currentCell = matrix[rowStart + 1, colStart];
                            if (currentCell == 'c')
                            {
                                matrix[rowStart + 1, colStart] = '*';
                                countCoals++;

                                if (countCoals == numberCoals)
                                {
                                    Console.WriteLine($"You collected all coals! ({rowStart + 1}, {colStart})");
                                    return;
                                }
                            }
                            else if (currentCell == 'e')
                            {
                                Console.WriteLine($"Game over! ({rowStart + 1}, {colStart})");
                                return;
                            }
                            else if (currentCell == '*')
                            {
                                rowStart += 1;
                                colStart = colStart;
                                continue;
                            }
                            rowStart += 1;
                            colStart = colStart;
                        }
                        
                        break;
                    case "right":
                        if (IsValid(matrix, rowStart, colStart + 1))
                        {
                            char currentCell = matrix[rowStart, colStart + 1];
                            if (currentCell == 'c')
                            {
                                matrix[rowStart, colStart + 1] = '*';
                                countCoals++;

                                if (countCoals == numberCoals)
                                {
                                    Console.WriteLine($"You collected all coals! ({rowStart}, {colStart+1})");
                                    return;
                                }
                            }
                            else if (currentCell == 'e')
                            {
                                Console.WriteLine($"Game over! ({rowStart}, {colStart+1})");
                                return;
                            }
                            else if (currentCell == '*')
                            {
                                rowStart = rowStart;
                                colStart += 1;
                                continue;
                            }
                            rowStart = rowStart;
                            colStart += 1;
                        }
                        
                        break;
                    case "left":
                        if (IsValid(matrix, rowStart, colStart - 1))
                        {
                            char currentCell = matrix[rowStart, colStart - 1];
                            if (currentCell == 'c')
                            {
                                matrix[rowStart, colStart - 1] = '*';
                                countCoals++;

                                if (countCoals == numberCoals)
                                {
                                    Console.WriteLine($"You collected all coals! ({rowStart}, {colStart - 1})");
                                    return;
                                }
                            }
                            else if (currentCell == 'e')
                            {
                                Console.WriteLine($"Game over! ({rowStart}, {colStart - 1})");
                                return;
                            }
                            else if (currentCell == '*')
                            {
                                rowStart = rowStart;
                                colStart -= 1;
                                continue;
                            }
                            rowStart = rowStart;
                            colStart -= 1;
                        }
                      
                        break;
                }
            }
            int remainingCoals = 0;
            remainingCoals = numberCoals - countCoals;
            Console.WriteLine($"{remainingCoals} coals left. ({ rowStart}, { colStart})");
        }

        private static int GetNumberCoals(char[,] matrix)
        {
            int count = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'c')
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        private static bool IsValid(char[,] matrix, int row, int column)
        {
            bool isValid = false;

            if (row >= 0 && row < matrix.GetLength(0) &&
                column >= 0 && column < matrix.GetLength(1))
            {
                isValid = true;
            }

            return isValid;
        }
        private static int[] FindStartPosition(char[,] matrix)
        {
            int rowStart = 0;
            int colStart = 0;
            int[] array = new int[2];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 's')
                    {
                        rowStart = row;
                        colStart = col;
                        array[0] = rowStart;
                        array[1] = colStart;
                    }
                }
            }
            return array;
        }
    }
}
