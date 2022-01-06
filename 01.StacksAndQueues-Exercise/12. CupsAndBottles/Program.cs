using System;
using System.Collections.Generic;
using System.Linq;

namespace _12._CupsAndBottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputCup = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] inputBottles = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Stack<int> bottles = new Stack<int>(inputBottles);
            Queue<int> cups = new Queue<int>(inputCup);

            int bottleNumber = bottles.Count;
            int currentCup = 0;
            int currentBottle = 0;
            int sumWater = 0;
            int remainingWater = 0;
            int countBottles = 0;

            for (int i = 0; i < bottleNumber; i++)
            {
                if (cups.Count > 0)
                {
                    currentCup = cups.Peek();
                }
                else
                {
                    break;
                }

                while (currentCup > 0)
                {
                    if (bottles.Count > 0)
                    {
                        currentBottle = bottles.Peek();
                        countBottles++;
                    }
                    else
                    {
                        break;
                    }

                    if (currentCup <= currentBottle)
                    {
                        remainingWater = currentBottle - currentCup;
                        sumWater += remainingWater;
                        bottles.Pop();
                        cups.Dequeue();
                        break;
                    }
                    else
                    {
                        if (bottles.Count > 0)
                        {
                            currentCup -= bottles.Pop();
                        }
                        if (countBottles == bottleNumber)
                        {
                            cups.Dequeue();
                            break;
                        }                 
                        continue;
                    }
                }
            }
            if (cups.Count <= 0)
            {
                Console.Write($"Bottles: ");
                Console.WriteLine(string.Join(" ", bottles));
            }
            else
            {
                Console.Write($"Cups: ");
                Console.WriteLine(string.Join(" ", cups));
            }

            Console.WriteLine($"Wasted litters of water: { sumWater}");
        }
    }
}
