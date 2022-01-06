using System;

namespace _02.Bee
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] territory = new char[n, n];

            int beeRow = 0;
            int beeCol = 0;
            for (int row = 0; row < n; row++)
            {
                char[] currentRow = Console.ReadLine().ToCharArray();

                for (int col = 0; col < n; col++)
                {
                    territory[row, col] = currentRow[col];
                    if (territory[row, col] == 'B')
                    {
                        beeRow = row;
                        beeCol = col;
                    }
                }
            }

            int neededFlowers = 5;
            bool isOutOfTeritory = false;
            int countPolinateFlowers = 0;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                territory[beeRow, beeCol] = '.';

                if (command == "up")
                {
                    beeRow -= 1;
                }
                else if (command == "down")
                {
                    beeRow += 1;
                }
                else if (command == "left")
                {
                    beeCol -= 1;
                }
                else if (command == "right")
                {
                    beeCol += 1;
                }

                isOutOfTeritory = isOut(territory, beeRow, beeCol);
                if (isOutOfTeritory)
                {
                    break;
                }

                if (territory[beeRow, beeCol] == 'f')
                {
                    countPolinateFlowers++;
                    territory[beeRow, beeCol] = 'B';
                }
                else if (territory[beeRow, beeCol] == 'O')
                {
                    territory[beeRow, beeCol] = '.';

                    switch (command)
                    {
                        case "up":
                            beeRow--;
                            break;
                        case "down":
                            beeRow++;
                            break;
                        case "left":
                            beeCol--;
                            break;
                        case "right":
                            beeCol++;
                            break;
                    }

                    isOutOfTeritory = isOut(territory, beeRow, beeCol);

                    if (isOutOfTeritory)
                    {
                        break;
                    }

                    if (territory[beeRow, beeCol] == 'f')
                    {
                        countPolinateFlowers++;
                    }

                    territory[beeRow, beeCol] = 'B';
                }

                territory[beeRow, beeCol] = 'B';
            }

            if (isOutOfTeritory)
            {
                Console.WriteLine($"The bee got lost!");
            }

            if (countPolinateFlowers < neededFlowers)
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {neededFlowers - countPolinateFlowers} flowers more");
            }
            else
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {countPolinateFlowers} flowers!");
            }


            for (int row = 0; row < territory.GetLength(0); row++)
            {
                for (int col = 0; col < territory.GetLength(1); col++)
                {
                    Console.Write(territory[row, col]);
                }
                Console.WriteLine();
            }
        }
        public static bool isOut(char[,] matrix, int row, int col)
        {
            return row < 0 || row >= matrix.GetLength(0) || col < 0 || col >= matrix.GetLength(1);
        }
    }
}
