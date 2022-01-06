using System;

namespace _01.ActionPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Action<string[]> print = items => Console.WriteLine(String.Join(Environment.NewLine, items));
            print(input);
        }
    }
}
