using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimentionsMatrix = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = dimentionsMatrix[0];
            int cols = dimentionsMatrix[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = 0;
                }
            }

            List<int> coordinates = new List<int>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Bloom Bloom Plow")
                {
                    for (int i = 0; i < coordinates.Count; i+=2)
                    {
                        int currentRow = coordinates[i];
                        int currentCol = coordinates[i + 1];
                        for (int col = 0; col < cols; col++)
                        {
                            matrix[currentRow, col] += 1;
                        }

                        for (int row = 0; row < cols; row++)
                        {
                            matrix[row, currentCol] += 1;
                        }
                        matrix[currentRow, currentCol] -= 1;
                    }

                    break;
                }

                int[] furionPosition = command
                                .Split()
                                .Select(int.Parse)
                                .ToArray();

                int furionRow = furionPosition[0];
                int furionCol = furionPosition[1];

                if (furionRow < 0 || furionRow >= rows || furionCol < 0 || furionCol >= cols)
                {
                    Console.WriteLine($"Invalid coordinates.");
                    continue;
                }
                else
                {
                    coordinates.Add(furionRow);
                    coordinates.Add(furionCol);
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]}" + " " );
                }
                Console.WriteLine();
            }
        }
    }
}
