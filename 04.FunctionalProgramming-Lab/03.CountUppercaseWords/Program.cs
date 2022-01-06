using System;
using System.Linq;

namespace _03.CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries );

            input = input.Where(x => char.IsUpper(x[0]) == true)
                 .ToArray();

            Console.Write(String.Join(Environment.NewLine, input));
        }
    }
}
