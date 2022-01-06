using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._BalancedParenthesis
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
                Queue<long[]> copy = new Queue<long[]>(sequence);
                long[] currentTank = copy.Dequeue();

                long litresOfPetrol = currentTank[0];
                long distance = currentTank[1];

                if (litresOfPetrol < distance)
                {
                    sequence.Enqueue(sequence.Dequeue());
                }
                else if (litresOfPetrol >= distance)
                {
                    fuelAmount = litresOfPetrol - distance;

                    while (copy.Any())
                    {
                        currentTank = copy.Dequeue();

                        litresOfPetrol = currentTank[0];
                        distance = currentTank[1];

                        if (litresOfPetrol + fuelAmount >= distance)
                        {
                            fuelAmount = litresOfPetrol + fuelAmount - distance;
                        }
                        else
                        {
                            sequence.Enqueue(sequence.Dequeue());
                            fuelAmount = -1;
                            break;
                        }
                    }

                    if (fuelAmount>=0)
                    {
                        Console.WriteLine(countPump);
                        break;
                    }
                }

                countPump++;

            }
        }
    }
}
