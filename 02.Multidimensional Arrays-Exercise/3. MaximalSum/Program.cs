using System;
using System.Linq;

namespace _3._MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine()
                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                   .Select(int.Parse)
                   .ToArray();

            int rows = dimentions[0];
            int cols = dimentions[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] numbers = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }

            int maxSum = int.MinValue;
            int sum = 0;
            int maxrow = 0;
            int maxcol = 0;

            for (int row = 0; row <= matrix.GetLength(0) - 3; row++)
            {

                for (int col = 0; col <= matrix.GetLength(1) - 3; col++)
                {
                    sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                        + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                        + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxrow = row;
                        maxcol = col;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");
    
            int lengthSubMatrix = maxrow;
            for (int row = maxrow; maxrow <= lengthSubMatrix + 2; maxrow++)
            {
                Console.WriteLine($"{matrix[maxrow, maxcol]} {matrix[maxrow, maxcol + 1]} {matrix[maxrow, maxcol + 2]}");
            }

        }
    }
}
