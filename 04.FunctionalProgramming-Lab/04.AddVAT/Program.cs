using System;
using System.Linq;

namespace _04.AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] prices = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(x => x *= 1.2)
                .Select(x=>x)
                .ToArray();

            foreach (var number in prices)
            {
                Console.WriteLine($"{number:F2}");
            }
        }
    }
}
