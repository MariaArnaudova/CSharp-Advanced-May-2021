using System;

namespace _7._KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int chessBoardDimention = int.Parse(Console.ReadLine());

            char[,] chessBoard = new char[chessBoardDimention,chessBoardDimention];

            for (int row = 0; row < chessBoard.GetLength(0); row++)
            {
                char[] currentRow = Console.ReadLine()
                   .ToCharArray();
                for (int col = 0; col < chessBoard.GetLength(1); col++)
                {
                    chessBoard[row, col] = currentRow[col];
                }
            }
       
            int knightRow = 0;
            int knightCol = 0;
            int knigtsCount = 0;
            while (true)
            {
                int maxAttacks = 0;
                for (int row = 0; row < chessBoard.GetLength(0); row++)
                {
                    
                    for (int col = 0; col < chessBoard.GetLength(1); col++)
                    {
                        int currentKnightsAttacks = 0;

                        if (chessBoard[row, col] == 'K')
                        {
                            // -2 1
                            if (IsInside(chessBoard, row - 2, col + 1) && chessBoard[row - 2, col + 1] == 'K')
                            {
                                currentKnightsAttacks++;
                            }
                            //-2-1
                            if (IsInside(chessBoard, row - 2, col - 1) && chessBoard[row - 2, col - 1] == 'K')
                            {
                                currentKnightsAttacks++;
                            }
                            // -1 2
                            if (IsInside(chessBoard, row - 1, col + 2) && chessBoard[row - 1, col + 2] == 'K')
                            {
                                currentKnightsAttacks++;
                            }
                            // -1 -2
                            if (IsInside(chessBoard, row - 1, col - 2) && chessBoard[row - 1, col - 2] == 'K')
                            {
                                currentKnightsAttacks++;
                            }
                            // 1 2
                            if (IsInside(chessBoard, row + 1, col + 2) && chessBoard[row + 1, col + 2] == 'K')
                            {
                                currentKnightsAttacks++;
                            }
                            //1-2
                            if (IsInside(chessBoard, row + 1, col - 2) && chessBoard[row + 1, col - 2] == 'K')
                            {
                                currentKnightsAttacks++;
                            }
                            //2-1
                            if (IsInside(chessBoard, row + 2, col - 1) && chessBoard[row + 2, col - 1] == 'K')
                            {
                                currentKnightsAttacks++;
                            }
                            //2 1
                            if (IsInside(chessBoard, row + 2, col + 1) && chessBoard[row + 2, col + 1] == 'K')
                            {
                                currentKnightsAttacks++;
                            }
                        }
                        if (currentKnightsAttacks > maxAttacks)
                        {
                            maxAttacks = currentKnightsAttacks;
                            knightRow = row;
                            knightCol = col;
                        }
                    }               
                }
                if (maxAttacks > 0)
                {
                    chessBoard[knightRow, knightCol] = '0';
                    knigtsCount++;
                }
                else
                {
                    Console.WriteLine(knigtsCount);
                    break;
                }
            }
        }

        private static bool IsInside(char[,] chessBoard, int row, int col)
        {
            bool isInsine = false;
            if (row>=0&&row<chessBoard.GetLength(0)&&
                col>=0 && col<chessBoard.GetLength(1))
            {
                isInsine = true;
            }
            return isInsine;
        }
    }
}
