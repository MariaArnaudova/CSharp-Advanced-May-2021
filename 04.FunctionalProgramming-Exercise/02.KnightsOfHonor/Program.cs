using System;
using System.Linq;

namespace _02.KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> appendWord = item => item = "Sir " + item;

            Action<string[]> print = word => Console.WriteLine(string.Join(Environment.NewLine, word));

            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(item => item = "Sir " + item)
                .ToArray();

            print(input);
        }
    }
}
