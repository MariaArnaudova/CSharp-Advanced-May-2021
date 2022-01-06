using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Tire[]> tiresColected = new List<Tire[]>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "No more tires")
                {
                    break;
                }

                string[] tiresInfo = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Tire[] tiers = new Tire[4];
                int countTiers = 0;
                for (int i = 0; i < tiresInfo.Length; i+=2)
                {                   
                    int yearTire = int.Parse(tiresInfo[i]);
                    double pressureTire = double.Parse(tiresInfo[i+1]);
                    Tire tire = new Tire(yearTire, pressureTire);
                    tiers[countTiers++] = tire;
                }
                tiresColected.Add(tiers);
            }

            List<Engine> engines = new List<Engine>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Engines done")
                {
                    break;
                }
                string[] engineInfo = input
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                int horsePower = int.Parse(engineInfo[0]);
                double cubicCapacity = double.Parse(engineInfo[1]);
                Engine engineCar = new Engine(horsePower, cubicCapacity);
                engines.Add(engineCar);
            }

            List<Car> cars = new List<Car>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Show special")
                {
                    break;
                }

                string[] carInfo = input
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                //{make} {model} {year} {fuelQuantity} {fuelConsumption} {engineIndex} {tiresIndex}
                string makeCar = carInfo[0];
                string modelCar = carInfo[1];
                int yearCar = int.Parse(carInfo[2]);
                double fuelQuantityCar = double.Parse(carInfo[3]);
                double fuelConsumptionCar = double.Parse(carInfo[4]);
                int engineIndex = int.Parse(carInfo[5]);
                int tiresIndex = int.Parse(carInfo[6]);

                Engine currentEngine = engines[engineIndex];
                Tire[] currentTires = tiresColected[tiresIndex];
                Car currentCar = new Car(makeCar, modelCar, yearCar, fuelQuantityCar, fuelConsumptionCar, currentEngine, currentTires);
                cars.Add(currentCar);
            }
            var listOfCars = cars.Where(car => car.Year >= 2017 && car.Engine.HorsePower > 300
                           && car.Tires.Sum(y => y.Pressure) >= 9 && car.Tires.Sum(y => y.Pressure) <= 10).ToList();
       
            foreach (var car in listOfCars)
            {
                car.Drive(20);
                Console.WriteLine(car.WhoAmI()); 
            }
        }
    }
}
