using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    public class Car
    {
        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometerv)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometerv = fuelConsumptionPerKilometerv;
            TravelledDistance = 0;
        }

        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometerv { get; set; }
        public double TravelledDistance { get; set; }

        public void Drive(int amountOfKm)
        {
            double needFuel = FuelConsumptionPerKilometerv * amountOfKm;
            bool canMoove = FuelAmount - needFuel >= 0;
            if (canMoove)
            {
                FuelAmount -= needFuel;
                TravelledDistance += amountOfKm;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
