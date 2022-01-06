using System;
using System.Collections.Generic;

namespace _05.FilterByAge
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Person[] people = new Person[n];

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(", ");

                people[i] = new Person();
                people[i].Name = input[0];
                people[i].Age = int.Parse(input[1]);
            }

            string conditionInfo = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            Func<Person, bool> condition = GetAgeCondition(conditionInfo, age);
            Func<Person, string> formatter = Getformatter(format);

            
            PrinPeople(people, condition, formatter);
        }

        static Func<Person, string> Getformatter(string format)
        {
            switch (format)
            {
                case "name": return p => $"{p.Name}";
                case "age": return p => $"{p.Age}";
                case "name age": return p => $"{p.Name} - {p.Age}";
                default:
                    return null;
            }
        }

        static Func<Person, bool> GetAgeCondition(string condition, int age)
        {
            switch (condition)
            {
                case "younger": return p => p.Age < age;
                case "older": return p => p.Age >= age;
                default: return null;
            }
        }

        static void PrinPeople(Person[] people, Func<Person, bool> condition, Func<Person, string> formatter)
        {
            foreach (var person in people)
            {
                if (condition(person))
                {
                    Console.WriteLine(formatter(person));
                }

            }
        }
    }

}
