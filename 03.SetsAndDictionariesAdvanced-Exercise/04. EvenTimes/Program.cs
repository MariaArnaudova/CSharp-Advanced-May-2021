using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            Dictionary<double, int> num = new Dictionary<double, int>();
            double number = 0;

            for (int i = 0; i < n; i++)
            {
                number = double.Parse(Console.ReadLine());
                if (!num.ContainsKey(number))
                {
                    num.Add(number, 1);
                }
                else
                {
                    num[number]++;
                }
            }

            // LINQ
            //var evenNum = num.Where(n => n.Value % 2 == 0).FirstOrDefault().Key;

            foreach (var item in num)
            {
                if (item.Value % 2 == 0)
                {
                    Console.WriteLine(item.Key);
                    break;
                }
            }
        }
    }
}
