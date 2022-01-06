using System;
using System.Collections.Generic;

namespace _8._TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int carsPassOnGreen = int.Parse(Console.ReadLine());

            string cars = Console.ReadLine();

            var passedCars = new Queue<string>();
            int countPassedCars = 0;

            while (cars != "end")
            {

                if (cars == "green")
                {
                    for (int i = 0; i < carsPassOnGreen; i++)
                    {
                        if (passedCars.Count > 0)
                        {
                            countPassedCars++;
                            Console.WriteLine($"{passedCars.Dequeue()} passed!");
                        }                     
                    }
                }
                else
                {
                    passedCars.Enqueue(cars);
                }

                cars = Console.ReadLine();
            }
            Console.WriteLine(countPassedCars + " cars passed the crossroads.");
        }
    }
}
