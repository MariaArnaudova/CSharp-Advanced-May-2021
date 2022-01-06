using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //Car car = new Car();
            //car.Make = "VW";
            //car.Model = "MK3";
            //car.Year = 1992;
            //car.FuelQuantity = 200;
            //car.FuelConsumption = 200;
            //car.Drive(2000);
            //Console.WriteLine($"Make: {car.Make} \nModel: { car.Model}\nYear: {car.Year}");
            //Console.WriteLine(car.WhoAmI());

            //string make = Console.ReadLine();
            //string model = Console.ReadLine();
            //int year = int.Parse(Console.ReadLine());
            //double fuelQuantity = double.Parse(Console.ReadLine());
            //double fuelConsumption = double.Parse(Console.ReadLine());

            //Car firstCar = new Car();
            //Car secondCar = new Car(make, model, year);
            //Car thirdCar = new Car(make, model, year, fuelQuantity, fuelConsumption);

            //var tires = new Tire[4]
            //{
            //    new Tire(1,2.5),
            //    new Tire(1, 2.0),
            //    new Tire(2,2.0),
            //    new Tire(2,2.3 )
            //};

            //var engine = new Engine(560, 6300);
            //var car2 = new Car("Lamborghini", "Urus", 2010, 250, 9, engine, tires);

            List<Tire> tiresColected = new List<Tire>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "No more tires")
                {
                    break;
                }

                string[] tiresInfo = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < tiresInfo.Length; i += 2)
                {
                    int yearTire = int.Parse(tiresInfo[i]);
                    double pressureTire = double.Parse(tiresInfo[i + 1]);
                    Tire tire = new Tire(yearTire, pressureTire);
                    tiresColected.Add(tire);
                }

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

                Car currentCar = new Car(makeCar, modelCar, yearCar, fuelQuantityCar,
                                        fuelConsumptionCar);
                cars.Add(currentCar);
            }


        }
    }
}
