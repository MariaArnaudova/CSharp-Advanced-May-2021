using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace _05.ComparingObjects
{
    public class Person : IComparable<Person>
    {
        private string name;
        private int age;
        private string town;
        public Person(string name, int age, string town)
        {
            this.name = name;
            this.age = age;
            this.town = town;
        }

        public string Name => this.name;

        public int Age => this.age;

        public string Town => this.town;
        public int CompareTo(Person other)
        {
            int result = this.Name.CompareTo(other.name);
            if (result == 0)
            {
                result = this.Age.CompareTo(other.age);
            }

            if (result == 0)
            {
                result = this.Town.CompareTo(other.town);
            }
            return result;
        }
    }
}
