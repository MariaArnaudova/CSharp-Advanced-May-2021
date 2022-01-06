using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking
{
    public class Parking
    { //•	Field data – collection that holds added cars
        private List<Car> cars;
        public Parking(string type, int capacity)
        {
            cars = new List<Car>();
            Type = type;
            Capacity = capacity;
        }
        public string Type { get; set; }
        public int Capacity { get; set; }

        //•	Getter Count – returns the number of cars.
        public int Count => cars.Count();

        //•	Method Add(Car car) – adds an entity to the data if there is an empty cell for the car.
        public void Add(Car car)
        {
            if (cars.Count < Capacity)
            {
                cars.Add(car);
            }
        }
        //•	Method Remove(string manufacturer, string model) – removes the car by given manufacturer and model
        //, if such exists, and returns bool.
        public bool Remove(string manufacturer, string model)
        {
            Car existingCar = cars.FirstOrDefault(x => x.Manufacturer == manufacturer && x.Model == model);
            if (existingCar != null)
            {
                cars.Remove(existingCar);
                return true;
            }
            return false;
        }

        //•	Method GetLatestCar() – returns the latest car (by year) or null if have no cars.
        public Car GetLatestCar()
        {
            Car latestCar = cars.OrderByDescending(x => x.Year).FirstOrDefault();
            if (latestCar != null)
            {
                return latestCar;
            }
            return null;
        }

        //•	Method GetCar(string manufacturer, string model) – returns the car with the given manufacturer
        //and model or null if there is no such car.
        public Car GetCar(string manufacturer, string model)
        {
            Car car = cars.FirstOrDefault(x => x.Manufacturer == manufacturer && x.Model == model);
            if (car!= null)
            {
                return car;
            }

            return null;
        }

        //•	GetStatistics() – returns a string in the following format:
        public string GetStatistics()
        { 
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The cars are parked in {Type}:");

            foreach (var car in cars)
            {
                sb.AppendLine(car.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
