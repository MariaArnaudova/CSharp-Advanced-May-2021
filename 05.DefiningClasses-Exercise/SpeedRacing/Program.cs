using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    class Program
    {
    
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] carInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
       
                string model = carInfo[0];
                double fuelAmount = double.Parse(carInfo[1]);
                double fuelConsumptionFor1km = double.Parse(carInfo[2]);

                Car newCar = new Car(model, fuelAmount, fuelConsumptionFor1km);
                cars.Add(newCar);
            }

            string command = Console.ReadLine();

            while (command!="End")
            {
             
                string[] driveCommand = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string carModel = driveCommand[1];
                int amountOfKm = int.Parse(driveCommand[2]);

                Car car = GetCar(cars, carModel);
                //Car car = cars.FirstOrDefault(car => car.Model==carModel);
                car.Drive(amountOfKm);

                command = Console.ReadLine();             
            }

            foreach ( var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.TravelledDistance}");
            }
        }

        private static Car GetCar(List<Car> cars, string model)
        {
            foreach (var car in cars)
            {
                if (car.Model==model)
                {
                    return car;
                }          
            }
            return null;
        }
    }
}
