using System;
using System.Linq;

namespace _6._Jagged_ArrayModification
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
                int[] rowsElemnts = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowsElemnts[col];
                }
            }

            while (true)
            {
                string[] commands = Console.ReadLine().Split();

                if (commands[0] == "END")
                {
                    break;
                }
                int row = int.Parse(commands[1]);
                int col = int.Parse(commands[2]);
                int value = int.Parse(commands[3]);

                if ((row < 0 || row > rows-1) || (col < 0 || col > cols-1))
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }

                if (commands[0] == "Add")
                {
                    matrix[row, col] += value;
                }
                else if (commands[0] == "Subtract")
                {
                    matrix[row, col] -= value;
                }
            }
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
