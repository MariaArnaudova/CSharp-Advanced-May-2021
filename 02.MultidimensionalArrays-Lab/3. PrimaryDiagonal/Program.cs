using System;
using System.Linq;

namespace _3._PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimentions = int.Parse(Console.ReadLine());
             
            int rows = dimentions;
            int cols = dimentions;

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] rowElemnts = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowElemnts[col];
                }
            }

            int sumDiagonalElements = 0;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (row==col)
                    {
                        sumDiagonalElements += matrix[row, col];
                    }
                }
            }
            Console.WriteLine(sumDiagonalElements);
        }
    }
}
