using System;
using System.Linq;

namespace _1._DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                int[] rowElements = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = rowElements[col];
                }
            }

            int sumFirstDiagonal = 0;
            int sumSeconddiagonal = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row == col)
                    {
                        sumFirstDiagonal += matrix[row, col];
                    }
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int indexElement = matrix.GetLength(0)-1 - row;
                sumSeconddiagonal += matrix[row, indexElement];
            }

            int difference = Math.Abs(sumFirstDiagonal - sumSeconddiagonal);
            Console.WriteLine(difference);
        }
    }
}
