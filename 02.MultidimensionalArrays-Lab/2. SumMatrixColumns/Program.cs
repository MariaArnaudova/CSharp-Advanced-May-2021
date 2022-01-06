using System;
using System.Linq;

namespace _2._SumMatrixColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

            int rows = dimentions[0];
            int cols = dimentions[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] rowsElement = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowsElement[col];
                }
            }

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int sumOfColumn = 0;

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    sumOfColumn += matrix[row, col];
                }

                Console.WriteLine(sumOfColumn);
            }
        }
    }
}
