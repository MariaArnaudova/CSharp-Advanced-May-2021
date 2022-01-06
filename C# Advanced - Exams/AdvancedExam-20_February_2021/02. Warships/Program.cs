using System;
using System.Linq;

namespace _02._Warships
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            string[] coordinates = Console.ReadLine().Split(",");

            char[,] field = new char[fieldSize, fieldSize];

            int firstPlayerShips = 0;
            int secondPalyerShips = 0;

            for (int row = 0; row < fieldSize; row++)
            {
                char[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();
                for (int col = 0; col < fieldSize; col++)
                {
                    field[row, col] = input[col];
                    if (field[row, col] == '<')
                    {
                        firstPlayerShips++;
                    }

                    if (field[row, col] == '>')
                    {
                        secondPalyerShips++;
                    }
                }
            }

            int firstRemainingShips = firstPlayerShips;
            int secondRemainingShips = secondPalyerShips;
            int totalCountShipsDestroyed = 0;

            for (int i = 0; i < coordinates.Length; i++)
            {
                int[] currentcoordinates = coordinates[i]
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int currentRow = currentcoordinates[0];
                int currentCol = currentcoordinates[1];

                if (currentRow < 0 || currentRow >= fieldSize || currentCol < 0 || currentCol >= fieldSize)
                {
                    continue;
                }

                if (IsPlayerOneShip(field, currentRow, currentCol))
                {
                    firstRemainingShips--;
                    totalCountShipsDestroyed++;
                    field[currentRow, currentCol] = 'X';
                }
                else if (IsPlayerTwoShip(field, currentRow, currentCol))
                {
                    secondRemainingShips--;
                    totalCountShipsDestroyed++;
                    field[currentRow, currentCol] = 'X';
                }
                else if (field[currentRow, currentCol] == '#')
                {
                    for (int row = currentRow - 1; row <= currentRow + 1; row++)
                    {
                        for (int col = currentCol - 1; col <= currentCol + 1; col++)
                        {
                            if (row >= 0 && row < fieldSize && col >= 0 && col < fieldSize)
                            {
                                if (IsPlayerOneShip(field, row, col))
                                {
                                    totalCountShipsDestroyed++;
                                    firstRemainingShips--;
                                    field[row, col] = 'X';
                                }
                                if (IsPlayerTwoShip(field, row, col))
                                {
                                    totalCountShipsDestroyed++;
                                    secondRemainingShips--;
                                    field[row, col] = 'X';
                                }
                            }
                        }
                    }
                }

                if (firstRemainingShips==0)
                {
                    break;
                }

                if (secondRemainingShips==0)
                {
                    break;
                }
            }

            if (secondRemainingShips<= 0)
            {
                Console.WriteLine($"Player One has won the game! {totalCountShipsDestroyed} ships have been sunk in the battle.");
                return;
            }
            else if (firstRemainingShips <= 0)
            {
                Console.WriteLine($"Player Two has won the game! {totalCountShipsDestroyed} ships have been sunk in the battle.");
                return;
            }
            else
            {
                Console.WriteLine($"It's a draw! Player One has {firstRemainingShips} ships left." +
                $" Player Two has {secondRemainingShips} ships left.");
            }
        }

        private static bool IsPlayerOneShip(char[,] matrix, int row, int col)
        {
            return matrix[row, col] == '<';
        }
        private static bool IsPlayerTwoShip(char[,] matrix, int row, int col)
        {
            return matrix[row, col] == '>';
        }
    }
}
