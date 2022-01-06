using System;
using System.Linq;

namespace _03.CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine()
              .Split(" ", StringSplitOptions.RemoveEmptyEntries)
              .Select(int.Parse)
              .ToArray();

            Func<int[], int> minFunc = inputNumbers =>
            {
                int minValue = int.MaxValue;
                foreach (var number in inputNumbers)
                {
                    if (number < minValue)
                    {
                        minValue = number;
                    }
                }
                return minValue;
            };

            int result = minFunc(inputNumbers);
            Console.WriteLine(result);
        }
    }
}
