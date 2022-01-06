using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] dividers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            List<int> num = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                num.Add(i);
            }

            Func<List<int>, int[], List<int>> IsDevisibleNumbers = (numbers, dividers) =>
            {
                List<int> dividedNumbers = new List<int>();
               
                for (int i = 0; i < numbers.Count; i++)
                {
                    bool isDividedAllNumbers = true;
                    for (int j = 0; j < dividers.Length; j++)
                    {
                        if (numbers[i] % dividers[j] != 0)
                        {
                            isDividedAllNumbers = false;
                            break;                            
                        }
                    }
                    if (isDividedAllNumbers)
                    {
                        dividedNumbers.Add(numbers[i]);
                    }                 
                }
                return dividedNumbers;
            };

            var dividetNumbers =IsDevisibleNumbers(num, dividers);

            Console.WriteLine(String.Join(" ", dividetNumbers));
        }
    }
}
