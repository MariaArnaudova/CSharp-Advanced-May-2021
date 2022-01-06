using System;
using System.Linq;

namespace _5._SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mattrixRowCow = Console.ReadLine()
               .Split(", ")
               .Select(int.Parse)
               .ToArray();

            int rows = mattrixRowCow[0];
            int cols = mattrixRowCow[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] rowsElement = Console.ReadLine()
                    .Split(", ")
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowsElement[col];
                }
            }

            int sum2x2Matrix = int.MinValue;
            int maxSumRow = 0;
            int maxSumCol = 0;

            int currentSum = 0;
            int subMatrixDimentions = 2;

            for (int row = 0; row < matrix.GetLength(0) - subMatrixDimentions +1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - subMatrixDimentions + 1; col++)
                {
                    currentSum = matrix[row, col] + matrix[row, col + 1]
                                 + matrix[row + 1, col] + matrix[row + 1, col + 1];

                    if (currentSum > sum2x2Matrix)
                    {
                        sum2x2Matrix = currentSum;
                        maxSumRow = row;
                        maxSumCol = col;
                    }
                }
            }
            Console.WriteLine($"{matrix[maxSumRow, maxSumCol]} {matrix[maxSumRow, maxSumCol+1]}");
            Console.WriteLine($"{matrix[maxSumRow+1, maxSumCol]} {matrix[maxSumRow+1, maxSumCol+1]}");
            Console.WriteLine(sum2x2Matrix);
        }
    }
}
