using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.FlowerWreaths
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] liliesInput = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] rosesInput = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int flowersPerOneWreath = 15;
            int countWreathsToDo = 5;
            int countWreaths = 0;

            Stack<int> lilies = new Stack<int>(liliesInput);
            Queue<int> roses = new Queue<int>(rosesInput);
            //List<int> storeFlowers = new List<int>();

            int sumFlowers = 0;
            int storedFlowers = 0;

            while (lilies.Count != 0 && roses.Count != 0)
            {
                sumFlowers = lilies.Peek() + roses.Peek();

                if (sumFlowers == flowersPerOneWreath)
                {
                    countWreaths++;
                    lilies.Pop();
                    roses.Dequeue();
                }
                else if (sumFlowers > flowersPerOneWreath)
                {
                    lilies.Push(lilies.Pop() - 2);
                }
                else if (sumFlowers < flowersPerOneWreath)
                {
                    storedFlowers += sumFlowers;
                    //storeFlowers.Add(sumFlowers);
                    lilies.Pop();
                    roses.Dequeue();
                }
                sumFlowers = 0;
            }

            if (storedFlowers > 0)
            {
                if (storedFlowers >= flowersPerOneWreath)
                {
                    int moreWreath = storedFlowers / flowersPerOneWreath;
                    countWreaths += moreWreath;
                }
            }

            if (countWreaths >= countWreathsToDo)
            {
                Console.WriteLine($"You made it, you are going to the competition with {countWreaths} wreaths!");
            }
            else
            {
                int wreathsNeed = countWreathsToDo - countWreaths;
                Console.WriteLine($"You didn't make it, you need {wreathsNeed} wreaths more!");
            }
        }
    }
}
