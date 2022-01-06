using System;
using System.Linq;

namespace _6._JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowsNumber = int.Parse(Console.ReadLine());

            double[][] arrays = new double[rowsNumber][];

            for (int row = 0; row < arrays.Length; row++)
            {
                arrays[row] = Console.ReadLine().Split().Select(double.Parse).ToArray();
            }

            AnalizeMatrix(arrays);

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                string[] commands = input.Split();

                string command = commands[0];
                int row = int.Parse(commands[1]);
                int column = int.Parse(commands[2]);
                double value = double.Parse(commands[3]);

                switch (command)
                {
                    case "Add":
                        if (IsValid(arrays, row, column))
                        {
                            arrays[row][column] += value;
                        }
                        break;
                   
                    case "Subtract":
                        if (IsValid(arrays, row, column))
                        {
                            arrays[row][column] -= value;
                        }
                        break;
                }
            }

            for (int row = 0; row < arrays.Length; row++)
            {
                Console.WriteLine(string.Join(" ", arrays[row]));
            }
        }

        private static bool IsValid(double[][] array, int row, int column)
        {
            bool isValid = false;

            if (row >= 0 && row < array.Length &&
                column >= 0 && column < array[row].Length)
            {
                isValid = true;
            }

            return isValid;
        }

        private static void AnalizeMatrix(double[][] jaggedArray)
        {
            for (int row = 0; row < jaggedArray.Length - 1; row++)
            {
                if (jaggedArray[row].Length == jaggedArray[row + 1].Length)
                {
                    for (int col = 0; col < jaggedArray[row].Length; col++)
                    {
                        jaggedArray[row][col] *= 2;
                        jaggedArray[row + 1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < jaggedArray[row].Length; col++)
                    {
                        jaggedArray[row][col] /= 2;
                    }
                    for (int col = 0; col < jaggedArray[row + 1].Length; col++)
                    {
                        jaggedArray[row + 1][col] /= 2;
                    }
                }
            }
        }
    }
}
