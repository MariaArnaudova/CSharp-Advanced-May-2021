using System;
using System.Collections.Generic;

namespace _7._HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();
            int order = int.Parse(Console.ReadLine());

            var children = new Queue<string>(names);

            while (children.Count > 1)
            {
                for (int i = 1; i <= order; i++)
                {

                    if (i == order)
                    {
                        Console.WriteLine($"Removed {children.Dequeue()}");
                    }
                    else
                    {
                        string lastKid = children.Dequeue();
                        children.Enqueue(lastKid);
                    }
                }
            }

            Console.WriteLine($"Last is {string.Join("", children)}");
        }
    }
}
