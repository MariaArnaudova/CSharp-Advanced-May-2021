using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int pumpsNumber = int.Parse(Console.ReadLine());

            Queue<long[]> sequence = new Queue<long[]>();

            for (int i = 0; i < pumpsNumber; i++)
            {
                long[] currentInfo = Console.ReadLine()
                    .Split()
                    .Select(long.Parse)
                    .ToArray();

                sequence.Enqueue(currentInfo);
            }

            long fuelAmount = 0;
            int countPump = 0;

            while (true)
            {
                bool foundPoint = true;
                long[] currentTank = sequence.Dequeue();

                for (int i = 0; i < pumpsNumber; i++)
                {
                   
                    long amountOfPetrol = currentTank[0];
                    long distance = currentTank[1];

                    fuelAmount += amountOfPetrol;

                    if (fuelAmount < distance)
                    {
                        foundPoint = false;
                        //sequence.Enqueue(currentTank);
                        break;
                    }

                    fuelAmount -= distance;

                    sequence.Enqueue(currentTank);
                }

                if (foundPoint|| countPump==pumpsNumber)
                {
                    break;
                }
                countPump++;
                sequence.Enqueue(currentTank);
            }
            if (fuelAmount>=0)
            {
                Console.WriteLine(countPump);
            }
            
        }
    }
}
