using System;
using System.Linq;

namespace _4._MatrixShuffling
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

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] numbers = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "END")
                {
                    break;
                }

                string[] coordinates = command.Split();

                if (coordinates[0] != "swap"|| coordinates.Length != 5)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
             
                int row1 = int.Parse(coordinates[1]);
                int col1 = int.Parse(coordinates[2]);
                int row2 = int.Parse(coordinates[3]);
                int col2 = int.Parse(coordinates[4]);

                if ((row1 < 0 || row1 > rows - 1)
                    || (col1 < 0 || col1 > cols - 1)
                    || (row2 < 0 || row2 > rows - 1)
                    || (col2 < 0 || col2 > cols - 1))
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                if (coordinates[0] == "swap")
                {
                    string firstElement = matrix[row1, col1];
                    matrix[row1, col1] = matrix[row2, col2];
                    matrix[row2, col2] = firstElement;

                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        for (int col = 0; col < matrix.GetLength(1); col++)
                        {
                            Console.Write(matrix[row, col] + " ");
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
