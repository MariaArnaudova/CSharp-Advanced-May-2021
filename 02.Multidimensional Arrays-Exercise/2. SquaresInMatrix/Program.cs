using System;
using System.Linq;

namespace _2._SquaresInMatrix
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

            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] characters = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = characters[col];
                }
            }

            char element = '\0';
            int count2x2matrix = 0;
            //int rowLength = matrix.GetLength(0) - 2;
            //int colLength = matrix.GetLength(1) - 2;

            for (int row = 0; row < matrix.GetLength(0)-1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    element = matrix[row, col];

                    if (element ==matrix[row, col+1] && 
                        element == matrix[row+1, col]&&
                        element == matrix[row+1, col+1])
                    {
                        count2x2matrix++;
                    }
                }
            }

            Console.WriteLine(count2x2matrix);
        }
    }
}
