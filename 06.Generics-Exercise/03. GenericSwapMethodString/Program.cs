using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._GenericSwapMethodString
{
    public class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());

            List<string> elements = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string currentInput = Console.ReadLine();
                elements.Add(currentInput);
            }

            int[] indexes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int firstIndex = indexes[0];
            int secondIndex = indexes[1];

            Box<string> box = new Box<string>(elements);

            box.Swap(firstIndex, secondIndex);

            Console.WriteLine(box.ToString());
        }
    }
}
