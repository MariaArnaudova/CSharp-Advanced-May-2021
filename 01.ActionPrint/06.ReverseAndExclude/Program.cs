using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Func<int[], int[]> reverse = numbers=>
            Action<List<int>> print = numbers => Console.WriteLine(String.Join(" ", numbers));
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int n = int.Parse(Console.ReadLine());

            Predicate<int> divise = n => n % 2 == 0;

            numbers.FindAll(n => divise(n)).Reverse();

            print(numbers);

        }
    }
}
