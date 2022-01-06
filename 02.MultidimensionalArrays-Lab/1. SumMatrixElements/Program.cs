using System;
using System.Linq;

namespace _1._SumMatrixElements
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

            int sum = 0;

            foreach (int number in matrix)
            {
                sum += number;
            }

            Console.WriteLine(rows);
            Console.WriteLine(cols);

            Console.WriteLine(sum);
        }
    }
}
