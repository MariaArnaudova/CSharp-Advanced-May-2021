using System;

namespace _02.Re_Volt
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowsCols = int.Parse(Console.ReadLine());
            int countCommands = int.Parse(Console.ReadLine());

            char[,] matrix = new char[rowsCols, rowsCols];
            int playerRow = 0;
            int playerCol = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] currentRow = Console.ReadLine().ToCharArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRow[col];
                    if (matrix[row, col] == 'f')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }

            bool isReachF = false;
            int countToReachCommands = 0;
            while (true)
            {
                countToReachCommands++;

                matrix[playerRow, playerCol] = '-';

                string command = Console.ReadLine();

                if (command == "up")
                {
                    if (playerRow - 1 < 0)
                    {
                        playerRow = rowsCols - 1;
                    }
                    else
                    {
                        playerRow -= 1;
                    }
                }
                else if (command == "down")
                {
                    if (playerRow + 1 > rowsCols - 1)
                    {
                        playerRow = 0;
                    }
                    else
                    {
                        playerRow += 1;
                    }
                }
                else if (command == "left")
                {
                    if (playerCol - 1 < 0)
                    {
                        playerCol = rowsCols - 1;
                    }
                    else
                    {
                        playerCol -= 1;
                    }
                }
                else if (command == "right")
                {
                    if (playerCol + 1 > rowsCols - 1)
                    {
                        playerCol = 0;
                    }
                    else
                    {
                        playerCol += 1;
                    }
                }

                if (matrix[playerRow, playerCol] == 'B')
                {
                    if (command == "up")
                    {
                        if (playerRow - 1 < 0)
                        {
                            playerRow = rowsCols - 1;
                        }
                        else
                        {
                            playerRow -= 1;
                        }
                    }
                    else if (command == "down")
                    {
                        if (playerRow + 1 > rowsCols - 1)
                        {
                            playerRow = 0;
                        }
                        else
                        {
                            playerRow += 1;
                        }
                    }
                    else if (command == "left")
                    {
                        if (playerCol - 1 < 0)
                        {
                            playerCol = rowsCols - 1;
                        }
                        else
                        {
                            playerCol -= 1;
                        }
                    }
                    else if (command == "right")
                    {
                        if (playerCol + 1 > rowsCols - 1)
                        {
                            playerCol = 0;
                        }
                        else
                        {
                            playerCol += 1;
                        }
                    }

                    if (matrix[playerRow, playerCol] == 'F')
                    {
                        matrix[playerRow, playerCol] = 'f';
                        isReachF = true;
                        break;
                    }

                    matrix[playerRow, playerCol] = 'f';
                }
                else if (matrix[playerRow, playerCol] == 'T')
                {
                    if (command == "up")
                    {
                        if (playerRow + 1 > rowsCols - 1)
                        {
                            playerRow = 0;
                        }
                        else
                        {
                            playerRow += 1;
                        }
                    }
                    else if (command == "down")
                    {
                        if (playerRow - 1 < 0)
                        {
                            playerRow = rowsCols - 1;
                        }
                        else
                        {
                            playerRow -= 1;
                        }
                    }
                    else if (command == "left")
                    {
                        if (playerCol + 1 > rowsCols - 1)
                        {
                            playerCol = 0;
                        }
                        else
                        {
                            playerCol += 1;
                        }
                    }
                    else if (command == "right")
                    {
                        if (playerCol - 1 < 0)
                        {
                            playerCol = rowsCols - 1;
                        }
                        else
                        {
                            playerCol -= 1;
                        }
                    }
                    matrix[playerRow, playerCol] = 'f';
                }
                else if (matrix[playerRow, playerCol] == '-')
                {
                    matrix[playerRow, playerCol] = 'f';
                }
                else if (matrix[playerRow, playerCol] == 'F')
                {
                    matrix[playerRow, playerCol] = 'f';
                    isReachF = true;
                    break;
                }

                if (countToReachCommands == countCommands)
                {

                    if (matrix[playerRow, playerCol] == 'F')
                    {
                        matrix[playerRow, playerCol] = 'f';
                        isReachF = true;
                        break;
                    }

                    break;
                }

            }
            //for (int i = 0; i < countCommands; i++)
            //{
            //    countToReachCommands++;
            //    matrix[playerRow, playerCol] = '-';

            //    string command = Console.ReadLine();

            //    if (command == "up")
            //    {
            //        if (playerRow - 1 < 0)
            //        {
            //            playerRow = rowsCols - 1;
            //        }
            //        else
            //        {
            //            playerRow -= 1;
            //        }
            //    }
            //    else if (command == "down")
            //    {
            //        if (playerRow + 1 > rowsCols - 1)
            //        {
            //            playerRow = 0;
            //        }
            //        else
            //        {
            //            playerRow += 1;
            //        }
            //    }
            //    else if (command == "left")
            //    {
            //        if (playerCol - 1 < 0)
            //        {
            //            playerCol = rowsCols - 1;
            //        }
            //        else
            //        {
            //            playerCol -= 1;
            //        }
            //    }
            //    else if (command == "right")
            //    {
            //        if (playerCol + 1 > rowsCols - 1)
            //        {
            //            playerCol = 0;
            //        }
            //        else
            //        {
            //            playerCol += 1;
            //        }
            //    }

            //    if (matrix[playerRow, playerCol] == 'B')
            //    {
            //        if (command == "up")
            //        {
            //            if (playerRow - 1 < 0)
            //            {
            //                playerRow = rowsCols - 1;
            //            }
            //            else
            //            {
            //                playerRow -= 1;
            //            }
            //        }
            //        else if (command == "down")
            //        {
            //            if (playerRow + 1 > rowsCols - 1)
            //            {
            //                playerRow = 0;
            //            }
            //            else
            //            {
            //                playerRow += 1;
            //            }
            //        }
            //        else if (command == "left")
            //        {
            //            if (playerCol - 1 < 0)
            //            {
            //                playerCol = rowsCols - 1;
            //            }
            //            else
            //            {
            //                playerCol -= 1;
            //            }
            //        }
            //        else if (command == "right")
            //        {
            //            if (playerCol + 1 > rowsCols - 1)
            //            {
            //                playerCol = 0;
            //            }
            //            else
            //            {
            //                playerCol += 1;
            //            }
            //        }
            //          if (matrix[playerRow, playerCol]=='F')
            //{
            //    matrix[playerRow, playerCol] = 'f';
            //    isReachF = true;
            //    break;
            //}

            //matrix[playerRow, playerCol] = 'f';
            //    }
            //    else if (matrix[playerRow, playerCol] == 'T')
            //    {
            //        if (command == "up")
            //        {
            //            if (playerRow + 1 > rowsCols - 1)
            //            {
            //                playerRow = 0;
            //            }
            //            else
            //            {
            //                playerRow += 1;
            //            }
            //        }
            //        else if (command == "down")
            //        {
            //            if (playerRow - 1 < 0)
            //            {
            //                playerRow = rowsCols - 1;
            //            }
            //            else
            //            {
            //                playerRow -= 1;
            //            }
            //        }
            //        else if (command == "left")
            //        {
            //            if (playerCol + 1 > rowsCols - 1)
            //            {
            //                playerCol = 0;
            //            }
            //            else
            //            {
            //                playerCol += 1;
            //            }
            //        }
            //        else if (command == "right")
            //        {
            //            if (playerCol - 1 < 0)
            //            {
            //                playerCol = rowsCols - 1;
            //            }
            //            else
            //            {
            //                playerCol -= 1;
            //            }
            //        }
            //        matrix[playerRow, playerCol] = 'f';
            //    }
            //    else if (matrix[playerRow, playerCol] == '-')
            //    {
            //        matrix[playerRow, playerCol] = 'f';
            //    }
            //    else if (matrix[playerRow, playerCol] == 'F' )
            //    {
            //        matrix[playerRow, playerCol] = 'f';
            //        isReachF = true;
            //        break;
            //    }
            //}

            if (isReachF)
            {
                Console.WriteLine($"Player won!");
            }
            else if ((countToReachCommands == countCommands) && !isReachF)
            {
                Console.WriteLine($"Player lost!");
            }

            for (int row = 0; row < rowsCols; row++)
            {
                for (int col = 0; col < rowsCols; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
