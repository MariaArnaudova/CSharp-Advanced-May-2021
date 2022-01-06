using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheRace
{
    public class Race
    {

        private List<Racer> racers;
        //private int count;
        public int Count
        {
            get
            {
                return this.racers.Count();
            }
        }
        public Race(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            racers = new List<Racer>();
        }
        public string Name { get; set; }

        public int Capacity { get; set; }

        public void Add(Racer racer)
        {
            //bool existingRacer = racers.Any(r => r.Name == racer.Name);
            if (racers.Count < this.Capacity)
            {
                racers.Add(racer);
            }
        }

        public bool Remove(string name)
        {
            bool existingRacer = racers.Any(r => r.Name == name);
            if (existingRacer)
            {
                racers.RemoveAll(r => r.Name == name);
                return true;
            }
            return false;
        }

        public Racer GetOldestRacer()
        {
            return racers.OrderByDescending(r => r.Age).First();
        }

        public Racer GetRacer(string name)
        {
            return racers.Where(r => r.Name == name).FirstOrDefault();
        }
        public Racer GetFastestRacer()
        {
            return racers.OrderByDescending(r => r.Car.Speed).FirstOrDefault();
        }
        public string Report()
        {
            //string newString = "";
            //newString = $"Racers participating at {this.Name}:" + Environment.NewLine;
            ////Console.WriteLine(newString);

            //foreach (var racer in racers)
            //{
            //    //newString += $"{racer.Name}" + Environment.NewLine;
            //    newString += racer.ToString() + Environment.NewLine;
            //}
            //return newString;

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Racers participating at { this.Name}:");
            //foreach (var racer in racers)
            //{
            //    sb.AppendLine($"{racer.ToString()}");
            //}

            for (int i = 0; i < racers.Count-1; i++)
            {
                sb.AppendLine($"{racers[i].ToString()}");
            }
            sb.Append($"{racers[racers.Count - 1].ToString()}");
            return sb.ToString();
        }
    }
}


