using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            //Person pesho = new Person("Pesho", 20);
            //Console.WriteLine($"{pesho.Name} {pesho.Age}");

            //Person gosho = new Person("Gosho", 18);
            //Console.WriteLine($"{gosho.Name} {gosho.Age}");

            //Person stamat = new Person("Stamat", 43);
            //Console.WriteLine($"{stamat.Name} {stamat.Age}");


            //Person pesho = new Person();

            //Person gosho = new Person(18);

            //Person stamat = new Person("Stamat", 43);

            //int n = int.Parse(Console.ReadLine());
            //Family newFamily = new Family();


            //for (int i = 0; i < n; i++)
            //{
            //    string[] names = Console.ReadLine()
            //        .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            //    string name = names[0];
            //    int age = int.Parse(names[1]);

            //    Person newPerson = new Person(name, age);
            //    newFamily.AddMember(newPerson);
            //}

            //Person oldestMember = newFamily.GetOldestMember();
            //Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");


            List<Person> persons = new List<Person>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] names = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = names[0];
                int age = int.Parse(names[1]);

                Person newPerson = new Person(name, age);
                persons.Add(newPerson);
            }

            persons = persons.Where(person => person.Age > 30)
                .OrderBy(p=>p.Name)
                .ToList();
            foreach (var person in persons)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
