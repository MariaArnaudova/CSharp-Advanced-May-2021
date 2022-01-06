using System;
using System.Collections.Generic;

namespace _7._Hot_Potato2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();
            int order = int.Parse(Console.ReadLine());

            var children = new Queue<string>(names);
            int potatosses = 0;

            while (children.Count > 1)
            {
                potatosses++;
                string kid = children.Dequeue();

                if (potatosses == order)
                {
                    potatosses = 0;
                    Console.WriteLine($"Removed {kid}");
                }
                else
                {
                    children.Enqueue(kid);
                }
            }

            Console.WriteLine("Last is " + children.Dequeue());
        }
    }
}
