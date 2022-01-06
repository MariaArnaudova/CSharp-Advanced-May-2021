using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.PredicateParty_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine().Split().ToList();

            string command = Console.ReadLine();
            Func<string, int, bool> lendthFunc = (name, length) => name.Length == length;
            Func<string, string, bool> startsWith = (name, pattern) => name.StartsWith(pattern);
            Func<string, string, bool> endsWith = (name, pattern) => name.EndsWith(pattern);

            while (command != "Party!")
            {
                string[] commandInfo = command.Split();
                string action = commandInfo[0];
                string condition = commandInfo[1];
                string element = commandInfo[2];

                if (action == "Double")
                {
                    if (condition == "Length")
                    {
                        int length = int.Parse(element);

                        var tempNames = people.Where(name => lendthFunc(name, length)).ToList();
                        MyAddRange(people, tempNames);
                    }
                    else if (condition == "StartsWith")
                    {
                        var tempNames = people.Where(name => startsWith(name, element)).ToList();
                        MyAddRange(people, tempNames);
                    }
                    else if (condition == "EndsWith ")
                    {
                        var tempNames = people.Where(name => endsWith(name, element)).ToList();
                        MyAddRange(people, tempNames);
                    }
                }
                else if (action == "Remove")
                {
                    if (condition == "Length")
                    {
                        int length = int.Parse(element);

                        people = people.Where(name => !lendthFunc(name, length)).ToList();
                    }
                    else if (condition == "StartsWith")
                    {
                        people = people.Where(name => !startsWith(name, element)).ToList();
                    }
                    else if (condition == "EndsWith ")
                    {
                        people = people.Where(name => !endsWith(name, element)).ToList();
                    }
                }
                command = Console.ReadLine();
            }

            if (people.Count > 0)
            {
                Console.WriteLine($"{String.Join(", ", people)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }

        }

        private static void MyAddRange(List<string> people, List<string> tempNames)
        {
            foreach (var currentNames in tempNames)
            {
                int indexName = people.IndexOf(currentNames);
                people.Insert(indexName, currentNames);
            }
        }
    }
}
