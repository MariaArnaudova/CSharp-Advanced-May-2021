using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
   public class Car
    {
        public Car(Tire[] tires)
        {
            Tires = tires;
        }
        public Car(string model, Engine engine, Cargo cargo, Tire[] tires)
        {
            Model = model;
            Engine = engine;
            Cargo = cargo;
            Tires = tires;
        }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }

        public Tire[] Tires { get; set; }

    }
}
