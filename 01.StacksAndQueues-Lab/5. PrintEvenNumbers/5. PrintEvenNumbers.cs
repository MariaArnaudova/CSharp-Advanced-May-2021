using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var integers = new Queue<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];

                if (currentNumber % 2 == 0)
                {
                    integers.Enqueue(currentNumber);
                }
            }

            Console.WriteLine(String.Join(", ", integers));
        }
    }
}
