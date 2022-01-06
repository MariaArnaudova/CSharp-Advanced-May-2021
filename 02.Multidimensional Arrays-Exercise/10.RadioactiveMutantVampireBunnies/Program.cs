using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.RadioactiveMutantVampireBunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] coordinates = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = coordinates[0];
            int cols = coordinates[1];

            char[,] lair = new char[rows, cols];
            int playerRow = 0;
            int playerCol = 0;

            bool isWon = false;
            bool isDead = false;

            for (int row = 0; row < rows; row++)
            {
                char[] inputRows = Console.ReadLine().ToCharArray();

                for (int col = 0; col < cols; col++)
                {
                    lair[row, col] = inputRows[col];
                    if (lair[row, col] == 'P')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }

            }
            char[] commands = Console.ReadLine().ToCharArray();
            for (int i = 0; i < commands.Length; i++)
            {
                int newPlayerRow = playerRow;
                int newPlayerCol = playerCol;

                char currentCommand = commands[i];
                switch (currentCommand)
                {
                    case 'U':
                        newPlayerRow--;
                        break;
                    case 'D':
                        newPlayerRow++;
                        break;
                    case 'L':
                        newPlayerCol--;
                        break;
                    case 'R':
                        newPlayerCol++;
                        break;
                }

                lair[playerRow, playerCol] = '.';

                if (IsOutOfFielld(newPlayerRow, newPlayerCol, rows, cols))
                {
                    isWon = true;
                }
                else if (!IsOutOfFielld(newPlayerRow, newPlayerCol, rows, cols))
                {
                    if (lair[newPlayerRow, newPlayerCol] == '.')
                    {
                        lair[newPlayerRow, newPlayerCol] = 'P';
                    }

                    if (lair[newPlayerRow, newPlayerCol] == 'B')
                    {
                        isDead = true;
                    }

                    playerRow = newPlayerRow;
                    playerCol = newPlayerCol;
                }

                List<int[]> bunniesCoordinates = GetBuniesCooordinates(lair);

                SpreadBunnies(bunniesCoordinates, lair);

                if (lair[playerRow, playerCol] == 'B')
                {
                    isDead = true;
                }

                if (isWon || isDead)
                {
                    break;
                }
            }

            if (isWon)
            {
                PrintMatrix(lair);
                Console.WriteLine($"won: {playerRow} {playerCol}");
            }
            else if (isDead)
            {
                PrintMatrix(lair);
                Console.WriteLine($"dead: {playerRow} {playerCol}");
            }
        }

        static List<int[]> GetBuniesCooordinates(char[,] lair)
        {
            List<int[]> coordinates = new List<int[]>();

            for (int row = 0; row < lair.GetLength(0); row++)
            {
                for (int col = 0; col < lair.GetLength(1); col++)
                {
                    if (lair[row, col] == 'B')
                    {
                        coordinates.Add(new int[] { row, col });
                    }
                }
            }
            return coordinates;
        }

        static void PrintMatrix(char[,] lair)
        {
            for (int row = 0; row < lair.GetLength(0); row++)
            {
                for (int col = 0; col < lair.GetLength(1); col++)
                {
                    Console.Write(lair[row, col]);
                }
                Console.WriteLine();
            }
        }

        static void SpreadBunnies(List<int[]> coordinates, char[,] lair)
        {
            foreach (int[] bunnyIndexes in coordinates)
            {
                int bunnyRow = bunnyIndexes[0];
                int bunnyCol = bunnyIndexes[1];

                if (bunnyRow - 1 >= 0)
                {
                    lair[bunnyRow - 1, bunnyCol] = 'B';
                }

                if (bunnyRow + 1 < lair.GetLength(0))
                {
                    lair[bunnyRow + 1, bunnyCol] = 'B';
                }

                if (bunnyCol - 1 >= 0)
                {
                    lair[bunnyRow, bunnyCol - 1] = 'B';
                }

                if (bunnyCol + 1 < lair.GetLength(1))
                {
                    lair[bunnyRow, bunnyCol + 1] = 'B';
                }
            }

        }

        static bool IsOutOfFielld(int newPlayerRow, int newPlayerCol, int rows, int cols)
        {
            return newPlayerRow < 0 || newPlayerRow >= rows
                || newPlayerCol < 0 || newPlayerCol >= cols;
        }
    }
}
