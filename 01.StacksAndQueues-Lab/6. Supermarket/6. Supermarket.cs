using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var customers = new Queue<string>();

            while (input != "End")
            {

                if (input == "Paid")
                {
                    while (customers.Count> 0)
                    {
                        Console.WriteLine(customers.Dequeue()); 
                    }
                }
                else
                {
                    customers.Enqueue(input);
                }

                input = Console.ReadLine();
            }
            int count = customers.Count();

            Console.WriteLine($"{count} people remaining.");
        }
    }
}
