using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            Dictionary<double, int> numbersCount = new Dictionary<double, int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (!numbersCount.ContainsKey(numbers[i]))
                {
                    numbersCount.Add(numbers[i], 0);
                }

                numbersCount[numbers[i]]++;
            }

            foreach (var item in numbersCount)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }

        }
    }
}
