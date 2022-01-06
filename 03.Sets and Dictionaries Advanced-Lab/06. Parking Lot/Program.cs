using System;
using System.Collections.Generic;

namespace _06._Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            HashSet<string> cars = new HashSet<string>();

            while (command!="END")
            {
                string[] carInfo = command.Split(", ");
                string direction = carInfo[0];
                string car = carInfo[1];

                switch(direction)
                {
                    case "IN":
                        cars.Add(car);
                        break;
                    case "OUT":
                        if (cars.Contains(car))
                        {
                            cars.Remove(car);
                        }
                        break;
                }
                command = Console.ReadLine();
            }

            if (cars.Count==0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var car in cars)
                {
                    Console.WriteLine(car);
                }
            }      
        }
    }
}
