using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());

            int[] orders = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> queueOrders = new Queue<int>(orders);

            int maxOrder = queueOrders.Max();
            Console.WriteLine(maxOrder);
            int ordersCount = queueOrders.Count;

            for (int i = 0; i < ordersCount; i++)
            {
                int currentOrder = orders[i];

                if (currentOrder <= foodQuantity)
                {
                    foodQuantity -= currentOrder;
                    queueOrders.Dequeue();
                }
                else
                {
                    Console.WriteLine($"Orders left: {string.Join(" ", queueOrders)}");                  
                    return;
                }
            }
            Console.WriteLine("Orders complete");
        }
    }
}
