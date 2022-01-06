using System;
using System.Linq;

namespace _02.SuperMario
{
    class Program
    {
        static void Main(string[] args)
        {
            int lives = int.Parse(Console.ReadLine());
            int numRows = int.Parse(Console.ReadLine());

            char[][] maze = new char[numRows][];
            // Read jagged array
            maze = ReadJaggedArray(maze);

            int rowMario = 0;
            int colMario = 0;
            bool isValidCeil = true;
            // Found Mario's start position
            for (int row = 0; row < numRows; row++)
            {
                for (int col = 0; col < maze[row].Length; col++)
                {
                    if (maze[row][col] == 'M')
                    {
                        rowMario = row;
                        colMario = col;
                    }
                }
            }

            isValidCeil = IsOutside(maze, rowMario, colMario, numRows);
            bool isLive = true;
            bool isSavePrincess = false;

            while (true)
            {
                int lastRowMario = rowMario;
                int lastColMario = colMario;
                // Read command
                string[] commandAndIndexes = Console.ReadLine()
                                             .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string direction = commandAndIndexes[0];
                int spawnRow = int.Parse(commandAndIndexes[1]);
                int spawnCol = int.Parse(commandAndIndexes[2]);
                maze[spawnRow][spawnCol] = 'B';
                lives -= 1;
                isValidCeil = true;
                //isValidCeil = IsOutside(jaggedArray, rowMario, colMario, numRows);
                // "W" (up), "S" (down), "A" (left), "D" (right).
                if (direction == "W")
                {
                    maze[rowMario][colMario] = '-';
                    rowMario -= 1;
                }
                else if (direction == "S")
                {
                    maze[rowMario][colMario] = '-';
                    rowMario += 1;
                }
                else if (direction == "A")
                {
                    maze[rowMario][colMario] = '-';
                    colMario -= 1;
                }
                else if (direction == "D")
                {
                    maze[rowMario][colMario] = '-';
                    colMario += 1;
                }
                // Check is valid ceil
                isValidCeil = IsOutside(maze, rowMario, colMario, numRows);


                if (!isValidCeil)
                {
                    rowMario = lastRowMario;
                    colMario = lastColMario;

                }
                else
                {

                    if (maze[rowMario][colMario] == 'B')
                    {
                        lives -= 2;
                        if (lives <= 0)
                        {
                            //isLive = false;
                            maze[rowMario][colMario] = 'X';
                            //maze[lastRowMario][lastColMario] = '-';
                            break;
                        }
                        maze[rowMario][colMario] = '-';
                    }

                    if (maze[rowMario][colMario] == 'P')
                    {
                        maze[rowMario][colMario] = '-';
                        //maze[lastRowMario][lastColMario] = '-';
                        isSavePrincess = true;
                        break;
                    }
                    // Check is Mario live
                    if (lives <= 0)
                    {
                        //isLive = false;
                        maze[rowMario][colMario] = 'X';
                        //maze[lastRowMario][lastColMario] = '-';
                        break;
                    }
                    else
                    {
                        maze[rowMario][colMario] = '-';
                    }
                    //else if (lives > 0 && jaggedArray[rowMario][colMario] == 'B')
                    //{
                    //    jaggedArray[rowMario][colMario] = '-';
                    //}
                }
            }
            if (isSavePrincess)
            {
                Console.WriteLine($"Mario has successfully saved the princess! Lives left: {lives}");
            }
            else /*if (!isLive)*/
            {
                Console.WriteLine($"Mario died at {rowMario};{colMario}.");
            }

            PrintjaggedArray(maze);
        }

        public static void PrintjaggedArray(char[][] jaggedArray)
        {
            for (int row = 0; row < jaggedArray.GetLength(0); row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    Console.Write(jaggedArray[row][col]);
                }
                Console.WriteLine();
            }
        }

        public static bool IsOutside(char[][] jaggedAray, int rowMario, int colMario, int numRows)
        {
            bool isOutside = true;
   
            if (!(rowMario < 0 && rowMario >= numRows)
                && (colMario < 0 && colMario >= jaggedAray[rowMario].Length))
            {
                isOutside = false;
            }
            return isOutside;
        }

        public static char[][] ReadJaggedArray(char[][] jaggedArray)
        {
            for (int row = 0; row < jaggedArray.Length; row++)
            {
                char[] inputRow = Console.ReadLine().ToCharArray();

                jaggedArray[row] = inputRow;
            }
            return jaggedArray;
        }
    }
}
