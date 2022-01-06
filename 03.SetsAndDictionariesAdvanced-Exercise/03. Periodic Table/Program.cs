using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            HashSet<string> uniqueElements = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] compounds = Console.ReadLine().Split();

                for (int j = 0; j < compounds.Length; j++)
                {
                    uniqueElements.Add(compounds[j]);
                }
            }

            Console.WriteLine(String.Join(" ", uniqueElements.OrderBy(e=>e)));
        }
    }
}
