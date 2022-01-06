using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> colection = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int divider = int.Parse(Console.ReadLine());
            //Predicate<int> divisibleByNumber = number => number % 2 == 0;

            Action<List<int>> print = numbers => Console.Write(String.Join(" ", numbers));

            colection.Reverse();
            colection.RemoveAll(n=>IsDivisibleByNumber(n, divider));

            print(colection);
        }

        static bool IsDivisibleByNumber(int number, int divider)
        {
            if (number % divider == 0)
            {
                return true;
            }
            return false;
        }
    }
}
