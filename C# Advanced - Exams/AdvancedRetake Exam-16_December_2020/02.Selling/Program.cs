using System;
using System.Collections.Generic;

namespace _02._Selling
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] bakery = new char[n, n];
            int sellerRow = 0;
            int sellerCol = 0;

            List<int[]> pillars = new List<int[]>();

            int[] firstPillar = new int[2];
            int[] secondPillar = new int[2];

            bool isDisappears = false;
            bool collectedEnoughMoney = false;
            int colectedMoney = 0;

            for (int row = 0; row < n; row++)
            {
                char[] currentRow = Console.ReadLine().ToCharArray();


                for (int col = 0; col < n; col++)
                {
                    bakery[row, col] = currentRow[col];
                    if (bakery[row, col] == 'S')
                    {
                        sellerRow = row;
                        sellerCol = col;
                        bakery[sellerRow, sellerCol] = 'S';
                    }

                    if (bakery[row, col] == 'O' && pillars.Count == 1)
                    {
                        secondPillar[0] = row;
                        secondPillar[1] = col;
                        pillars.Add(firstPillar);
                    }
                    else if (bakery[row, col] == 'O' && pillars.Count == 0)
                    {
                        firstPillar[0] = row;
                        firstPillar[1] = col;
                        pillars.Add(firstPillar);
                    }
                }
            }

            while (true)
            {
                bakery[sellerRow, sellerCol] = '-';

                string commands = Console.ReadLine();

                if (commands == "up")
                {
                    //    if (sellerCol - 1 < 0)
                    //    {
                    //        isDisappears = true;
                    //        break;
                    //    }
                    //    sellerRow--;

                    //if (IsGoOut(sellerRow-1, sellerCol, n))
                    //{
                    //    isDisappears = true;
                    //    break;
                    //}
                    sellerRow--;
                }
                else if (commands == "down")
                {
                    //if (sellerRow + 1 >= n)
                    //{
                    //    isDisappears = true;
                    //    break;
                    //}
                    //sellerRow++;

                //if (IsGoOut(sellerRow + 1, sellerCol, n))
                //{
                //    isDisappears = true;
                //    break;
                //}
                sellerRow++;
            }
                else if (commands == "left")
                {
                    //if (sellerCol - 1 < 0)
                    //{
                    //    isDisappears = true;
                    //    break;
                    //}
                    //sellerCol--;

                    //if (IsGoOut(sellerRow , sellerCol-1, n))
                    //{
                    //    isDisappears = true;
                    //    break;
                    //}
                    sellerCol--;
                }
                else if (commands == "right")
                {
                    //if (sellerCol + 1 >= n)
                    //{
                    //    isDisappears = true;
                    //    break;
                    //}
                    //sellerCol++;

                    //if (IsGoOut(sellerRow, sellerCol + 1, n))
                    //{
                    //    isDisappears = true;
                    //    break;
                    //}
                    sellerCol++;
                }

                if (IsGoOut(sellerRow, sellerCol, n))
                {
                    isDisappears = true;
                }
                else if (!IsGoOut(sellerRow, sellerCol, n))
                {
                    if (Char.IsDigit(bakery[sellerRow, sellerCol]))
                    {
                        int price = int.Parse(bakery[sellerRow, sellerCol].ToString());
                        colectedMoney += price;

                        if (colectedMoney >= 50)
                        {
                            collectedEnoughMoney = true;
                            bakery[sellerRow, sellerCol] = 'S';
                        }
                    }
                    else if (bakery[sellerRow, sellerCol] == 'O')
                    {
                        if (firstPillar[0] == sellerRow && firstPillar[1] == sellerCol)
                        {
                            bakery[sellerRow, sellerCol] = '-';
                            sellerRow = secondPillar[0];
                            sellerCol = secondPillar[1];
                            bakery[sellerRow, sellerCol] = 'S';
                        }
                        else if (secondPillar[0] == sellerRow && secondPillar[1] == sellerCol)
                        {
                            bakery[sellerRow, sellerCol] = '-';
                            sellerRow = firstPillar[0];
                            sellerCol = firstPillar[1];
                            bakery[sellerRow, sellerCol] = 'S';
                        }
                    }
                }

                if (isDisappears || collectedEnoughMoney)
                {
                    break;
                }

            }

            if (isDisappears)
            {
                Console.WriteLine($"Bad news, you are out of the bakery.");
            }
            else
            {
                Console.WriteLine($"Good news! You succeeded in collecting enough money!");
            }


            Console.WriteLine($"Money: {colectedMoney}");

            PrintBakery(bakery);
        }

        private static void PrintBakery(char[,] bakeri)
        {
            for (int row = 0; row < bakeri.GetLength(0); row++)
            {
                for (int col = 0; col < bakeri.GetLength(1); col++)
                {
                    Console.Write(bakeri[row, col]);
                }
                Console.WriteLine();
            }
        }

        private static bool IsGoOut(int newRow, int newCol, int n)
        {
            return newRow < 0 || newRow >= n || newCol < 0 || newCol >= n;
        }
    }
}