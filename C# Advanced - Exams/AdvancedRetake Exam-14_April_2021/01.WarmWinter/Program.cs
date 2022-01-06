using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.WarmWinter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputHats = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> inputScarfs = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            Stack<int> hats = new Stack<int>(inputHats);
            Queue<int> scarfs = new Queue<int>(inputScarfs);
            List<int> sets = new List<int>();

            for (int i = 0; i < hats.Count; i++)
            {
                int currentHat = hats.Peek();
                for (int j = 0; j < scarfs.Count; j++)
                {
                    int currentScarf = scarfs.Peek();

                    if (currentHat > currentScarf)
                    {
                        currentHat += currentScarf;
                        sets.Add(currentHat);
                        hats.Pop();
                        scarfs.Dequeue();
                        //break;
                    }
                    else if (currentScarf > currentHat)
                    {
                        hats.Pop();
                        //break;
                    }
                    else if (currentHat == currentScarf)
                    {
                        scarfs.Dequeue();
                        currentHat += 1;
                        hats.Pop();
                        hats.Push(currentHat);
                        //break;
                    }
                    i = -1;
                    j = -1;
                    break;
                }
            }

            int mostExpensiveSet = sets.Max();
            Console.WriteLine($"The most expensive set is: {mostExpensiveSet}");

            Console.WriteLine(String.Join(" ", sets));
        }
    }
}
