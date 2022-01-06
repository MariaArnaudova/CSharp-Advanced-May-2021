using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimentions = int.Parse(Console.ReadLine());

            int rows = dimentions;
            int cols = dimentions;

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

            List<string> coordinates = Console.ReadLine().Split().ToList();
            int sumRow = 0;
            for (int i = 0; i < coordinates.Count; i++)
            {
                string[] currentCoordinates = coordinates[i].Split(',',
                    StringSplitOptions.RemoveEmptyEntries);
                int rowBomb = int.Parse(currentCoordinates[0]);
                int colBomb = int.Parse(currentCoordinates[1]);

                int currentBomb = matrix[rowBomb, colBomb];
                if (matrix[rowBomb, colBomb] > 0)
                {
                    if (IsInside(matrix, rowBomb, colBomb - 1) && matrix[rowBomb, colBomb - 1] > 0)
                    {
                        matrix[rowBomb, colBomb - 1] -= matrix[rowBomb, colBomb];
                    }
                    if (IsInside(matrix, rowBomb, colBomb + 1) && matrix[rowBomb, colBomb + 1] > 0)
                    {
                        matrix[rowBomb, colBomb + 1] -= matrix[rowBomb, colBomb];
                    }
                    if (IsInside(matrix, rowBomb - 1, colBomb) && matrix[rowBomb - 1, colBomb] > 0)
                    {
                        matrix[rowBomb - 1, colBomb] -= matrix[rowBomb, colBomb];
                    }
                    if (IsInside(matrix, rowBomb - 1, colBomb - 1) && matrix[rowBomb - 1, colBomb - 1] > 0)
                    {
                        matrix[rowBomb - 1, colBomb - 1] -= matrix[rowBomb, colBomb];
                    }
                    if (IsInside(matrix, rowBomb - 1, colBomb + 1) && matrix[rowBomb - 1, colBomb + 1] > 0)
                    {
                        matrix[rowBomb - 1, colBomb + 1] -= matrix[rowBomb, colBomb];
                    }
                    if (IsInside(matrix, rowBomb + 1, colBomb) && matrix[rowBomb + 1, colBomb] > 0)
                    {
                        matrix[rowBomb + 1, colBomb] -= matrix[rowBomb, colBomb];
                    }
                    if (IsInside(matrix, rowBomb + 1, colBomb - 1) && matrix[rowBomb + 1, colBomb - 1] > 0)
                    {
                        matrix[rowBomb + 1, colBomb - 1] -= matrix[rowBomb, colBomb];
                    }
                    if (IsInside(matrix, rowBomb + 1, colBomb + 1) && matrix[rowBomb + 1, colBomb + 1] > 0)
                    {
                        matrix[rowBomb + 1, colBomb + 1] -= matrix[rowBomb, colBomb];
                    }

                    matrix[rowBomb, colBomb] = 0;
                }         
            }

            int aliveCells = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] > 0)
                    {
                        aliveCells++;
                        sumRow += matrix[row, col];
                    }
                }
            }

            Console.WriteLine($"Alive cells: {aliveCells}");
            Console.WriteLine($"Sum: {sumRow}");

            PrintMatrix(matrix);
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (col == matrix.GetLength(1) - 1)
                    {
                        Console.Write(matrix[row, col]);
                    }
                    else
                    {
                        Console.Write(matrix[row, col] + " ");
                    }
                }
                Console.WriteLine();
            }
        }

        private static bool IsInside(int[,] matrix, int rowBomb, int colBomb)
        {
            bool isInsine = false;
            if (rowBomb >= 0 && rowBomb < matrix.GetLength(0) &&
                colBomb >= 0 && colBomb < matrix.GetLength(1))
            {
                isInsine = true;
            }
            return isInsine;
        }
    }
}
