
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        public Family()
        {
            People = new List<Person>();
        }
        public List<Person> People { get; set; }
        public void AddMember(Person member)
        {
            People.Add(member);
        }
        public Person GetOldestMember()
        {
            //Person oldesMember = People.OrderByDescending(p => p.Age).First(); //LINQ
            ////return oldesMember; 
            int maxAge = int.MinValue;
            Person person = null;

            foreach (var currentPerson in People)
            {
                int currentAge = currentPerson.Age;
                if (currentAge > maxAge)
                {
                    maxAge = currentAge;
                    person = currentPerson;
                }
            }
            return person;
        }

    }
}
