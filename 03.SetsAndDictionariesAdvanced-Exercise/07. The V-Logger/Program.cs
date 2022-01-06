using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._The_V_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Vlogger> vloggers = new HashSet<Vlogger>();
            string[] input = Console.ReadLine().Split();

            while (input[0] != "Statistics")
            {
                switch (input[1])
                {
                    case "joined":
                        Vlogger newVlogger = new Vlogger(input[0]);

                        if (!vloggers.Any(v => v.Name == newVlogger.Name))
                        {
                            vloggers.Add(newVlogger);
                        }

                        break;
                    case "followed":
                        //Saffrona followed EmilConrad
                        string following = input[0];
                        string followed = input[2];

                        if (followed != following && vloggers.Any(v => v.Name == following) && vloggers.Any(v => v.Name == followed))
                        {
                            Vlogger vlogger1 = vloggers.Where(v => v.Name == following).FirstOrDefault(); // Sarffrona
                            if (vloggers.Contains(vlogger1))
                            {
                                vlogger1.AddFollowing(followed);
                            }

                            Vlogger vlogger2 = vloggers.Where(v => v.Name == followed).FirstOrDefault();// EmilConrad
                            if (vloggers.Contains(vlogger2))
                            {
                                vlogger2.AddFollower(following);
                            }
                        }
                        break;
                }
                input = Console.ReadLine().Split();
            }

            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");

            if (vloggers.Count==0)
            {
                return;
            }

            int maxFollowers = int.MinValue;

            foreach (var item in vloggers)
            {
                if (item.Followers.Count > maxFollowers)
                {
                    maxFollowers = item.Followers.Count;
                }
   
            }
            var famous = vloggers.Where(v => v.Followers.Count == maxFollowers).FirstOrDefault();
            //var mostFamous = vloggers.Where(v => v.Followers.Count == maxFollowers);
            
            Console.WriteLine($"1. {famous.Name} : {famous.Followers.Count} followers, {famous.Following.Count} following");

            foreach (var follower in famous.Followers)
            {
                Console.WriteLine($"*  {follower}");
            }

            vloggers.Remove(famous);

            var sorted = vloggers.OrderByDescending(v => v.Followers.Count).ThenBy(v => v.Following.Count);

            int counter = 2;
            foreach (var item in sorted)
            {

                Console.WriteLine($"{counter}. {item.Name} : {item.Followers.Count} followers, {item.Following.Count} following");
                counter++;
            }
        }
    }
    public class Vlogger
    {
        public string Name { get; set; }
        public SortedSet<string> Followers { get; set; }
        public HashSet<string> Following { get; set; }

        public Vlogger(string name)
        {

            this.Name = name;
            this.Followers = new SortedSet<string>();
            this.Following = new HashSet<string>();

        }
        public void AddFollower(string name)
        {
            Followers.Add(name);
        }

        public void AddFollowing(string name)
        {
            Following.Add(name);
        }
    }
}
