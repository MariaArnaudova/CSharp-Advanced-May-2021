using System;
using System.Collections.Generic;

namespace _10._Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLight = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());

            Queue<string> cars = new Queue<string>();
            int totalCarsPassed = 0;
            string passCar = "";

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "END")
                {
                    break;
                }

                if (command == "green")
                {
                    int passedGreenLight = greenLight;

                    while (cars.Count > 0 && passedGreenLight > 0)
                    {
                        passCar = cars.Dequeue();

                        if (passCar.Length < passedGreenLight)
                        {
                            passedGreenLight -= passCar.Length;
                            totalCarsPassed++;
                        }
                        else if (passCar.Length >= passedGreenLight && passedGreenLight > 0)
                        {

                            for (int i = 0; i < passCar.Length; i++)
                            {
                                int characterHit = i;

                                if (characterHit == passedGreenLight + freeWindow)
                                {
                                    Console.WriteLine("A crash happened!");
                                    Console.WriteLine($"{passCar} was hit at {passCar[i]}.");
                                    return;
                                }
                            }
                            passedGreenLight = 0;
                            totalCarsPassed++;
                        }
                    }
                }
                else
                {
                    cars.Enqueue(command);
                }
            }
            Console.WriteLine($"Everyone is safe.");
            Console.WriteLine($"{totalCarsPassed} total cars passed the crossroads.");
        }
    }
}
