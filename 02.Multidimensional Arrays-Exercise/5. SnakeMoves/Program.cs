using System;
using System.Linq;

namespace _5._SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine()
           .Split(" ", StringSplitOptions.RemoveEmptyEntries)
           .Select(int.Parse)
           .ToArray();

            string word = Console.ReadLine();

            int rows = dimentions[0];
            int cols = dimentions[1];

            char[,] matrix = new char[rows, cols];
            int countCharsOfWord = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {                
                        matrix[row, col] = word[countCharsOfWord];
                        countCharsOfWord++;
                        if (countCharsOfWord == word.Length)
                        {
                            countCharsOfWord = 0;
                        }
                    }
                }
                else
                {
                    for (int col = matrix.GetLength(1); col > 0; col--)
                    {                       
                        matrix[row, col-1] = word[countCharsOfWord];
                        countCharsOfWord++;
                        if (countCharsOfWord == word.Length)
                        {
                            countCharsOfWord = 0;
                        }
                    }
                }
            }

            PrintMatrix(matrix);
        }

        private static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
