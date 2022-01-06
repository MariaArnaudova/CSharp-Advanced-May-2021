using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Lootbox
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstLotBox = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] secondLotBox = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            List<int> climedItems = new List<int>();

            Queue<int> firstBox = new Queue<int>(firstLotBox);
            Stack<int> secondBox = new Stack<int>(secondLotBox);

            while (firstBox.Count != 0 && secondBox.Count != 0)
            {
                int sumNumbers = firstBox.Peek() + secondBox.Peek();
                if (sumNumbers % 2 == 0)
                {
                    climedItems.Add(sumNumbers);
                    firstBox.Dequeue();
                    secondBox.Pop();
                }
                else
                {
                    int lastItemFromSecondBox = secondBox.Pop();
                    firstBox.Enqueue(lastItemFromSecondBox);
                }
            }

            if (firstBox.Count == 0)
            {
                Console.WriteLine($"First lootbox is empty");
            }
            else
            {
                Console.WriteLine($"Second lootbox is empty");
            }
            int climedItemsSum = climedItems.Sum();

            if (climedItemsSum >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {climedItemsSum}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {climedItemsSum}");
            }
        }
    }
}
