﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] infoNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int numberElementsPush = infoNumbers[0];
            int numberElementsPop = infoNumbers[1];
            int elementsToLook = infoNumbers[2];

            Queue<int> colections = new Queue<int>();

            for (int i = 0; i < numberElementsPush; i++)
            {
                colections.Enqueue(numbers[i]);
            }

            for (int i = 0; i < numberElementsPop; i++)
            {
                colections.Dequeue();
            }

            bool contains = colections.Contains(elementsToLook);

            int smalestElement = int.MaxValue;

            if (contains)
            {
                Console.WriteLine("true");
            }
            else
            {
                if (colections.Count > 0)
                {
                    foreach (var item in colections)
                    {
                        if (item < smalestElement)
                        {
                            smalestElement = item;
                        }
                    }
                    Console.WriteLine(smalestElement);
                }
                else
                {
                    Console.WriteLine("0");
                }
            }
        }
    }
}
