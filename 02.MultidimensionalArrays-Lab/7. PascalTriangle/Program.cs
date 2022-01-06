using System;

namespace _7._PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersRows = int.Parse(Console.ReadLine());

            long[][] pascalTriangle = new long[numbersRows][];
  
            for (int row = 0; row < numbersRows; row++)
            {
                pascalTriangle[row] = new long[row + 1];      
            }

            for (int i= 0; i < numbersRows; i++)
            {
                pascalTriangle[i][0] = 1;
                pascalTriangle[i][pascalTriangle[i].Length - 1] = 1;

                for (int j = 1; j < pascalTriangle[i].Length - 1; j++)
                {
                    pascalTriangle[i][j] = pascalTriangle[i - 1][j] +
                                           pascalTriangle[i - 1][j - 1];
                }
            }

            foreach (var array in pascalTriangle)
            {
                Console.WriteLine(string.Join(" ", array));
            }

        }
    }
}
