using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> numbers = new Stack<int>(input);

            while (true)
            {
                string[] inputCommand = Console.ReadLine().Split();

                string command = inputCommand[0].ToLower();

                if (command == "end")
                {
                    break;
                }

                if (command == "add")
                {
                    int num1 = int.Parse(inputCommand[1]);
                    int num2 = int.Parse(inputCommand[2]);

                    numbers.Push(num1);
                    numbers.Push(num2);
                }
                else if (command == "remove")
                {
                    int removedNumber = int.Parse(inputCommand[1]);

                    if (removedNumber <= numbers.Count)
                    {

                        for (int i = 0; i < removedNumber; i++)
                        {
                            numbers.Pop();
                        }
                    }
                }
            }

            Console.WriteLine($"Sum: {numbers.Sum()}");
        }
    }
}
