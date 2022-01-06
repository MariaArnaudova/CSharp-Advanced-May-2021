using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._SetOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nm = Console.ReadLine().Split().Select(int.Parse).ToArray();
            HashSet<int> furstNumbers = new HashSet<int>();
            HashSet<int> secondNumbers = new HashSet<int>();
            //List<int> uniqueNumbers = new List<int>();

            int n = nm[0];
            int m = nm[1];

            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                furstNumbers.Add(currentNumber);
            }

            for (int i = 0; i < m; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (furstNumbers.Contains(currentNumber))
                {
                    secondNumbers.Add(currentNumber);
                }                              
            }

            furstNumbers.IntersectWith(secondNumbers);
            Console.WriteLine(String.Join(" ", furstNumbers));
        }
    }
}
