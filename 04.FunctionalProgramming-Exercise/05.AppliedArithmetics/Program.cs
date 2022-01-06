using System;
using System.Linq;

namespace _05.AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Func<int, int> addNumber = number => number += 1;
            Func<int, int> multiply = number => number *= 2;
            Func<int, int> subtract = number => number -= 1;

            Action<int[]> print = numbers => Console.WriteLine(String.Join(" ", numbers));

            string input = Console.ReadLine();

            while (input != "end")
            {

                if (input == "add")
                {
                    numbers = numbers.Select(addNumber).ToArray();
                }
                else if (input == "multiply")
                {
                    numbers = numbers.Select(multiply).ToArray();
                }
                else if (input == "subtract")
                {
                    numbers = numbers.Select(subtract).ToArray();
                }
                else if (input == "print")
                {
                    print(numbers);
                }
                input = Console.ReadLine();
            }
        }
    }
}
