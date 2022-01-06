using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FindEvensrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> IsEvenPredicate = n => n % 2 == 0;
            Action<List<int>> print = numbers => Console.WriteLine(String.Join(" ", numbers));

            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            List<int> numbers = new List<int>();

            int startNumber = input[0];
            int lastNumber = input[1];

            for (int i = startNumber; i <= lastNumber; i++)
            {
                numbers.Add(i);
            }

            string numberType = Console.ReadLine();
            List<int> result = new List<int>();

            if (numberType == "even")
            {

                numbers.RemoveAll(x => !IsEvenPredicate(x));
                //result = numbers.FindAll(x => !IsEvenPredicate(x));

            }
            else
            {
                numbers.RemoveAll(x => IsEvenPredicate(x));
                //result = numbers.FindAll(x => IsEvenPredicate(x));
            }

            print(numbers);
        }
    }
}
