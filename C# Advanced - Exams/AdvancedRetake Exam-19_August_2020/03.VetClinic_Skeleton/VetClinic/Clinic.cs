using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VetClinic
{
    public class Clinic
    {
        private List<Pet> pets;
        public Clinic(int capacity)
        {
            pets = new List<Pet>();
            this.Capacity = capacity;
        }
        public int Capacity { get; set; }

        // •	Getter Count – returns the number of pets.
        public int Count => pets.Count();

        //•	Method Add(Pet pet) – adds an entity to the data if there is an empty cell for the pet.
        public void Add(Pet pet)
        {
            if (pets.Count < Capacity)
            {
                pets.Add(pet);
            }
        }

        // Method Remove(string name) – removes the pet by given name, if such exists, and returns bool.
        public bool Remove(string name)
        {
            if (pets.Exists(x => x.Name == name))
            {
                Pet removedPet = pets.FirstOrDefault(x => x.Name == name);
                pets.Remove(removedPet);

                return true;
            }
            return false;
        }

        // •	Method GetPet(string name, string owner) 
        // – returns the pet with the given name and owner or null if no such pet exists.
        public Pet GetPet(string name, string owner)
        {
            Pet searchedPet = pets.FirstOrDefault(x => x.Name == name && x.Owner == owner);
            if (searchedPet != null)
            {
                return searchedPet;
            }
            return null;
        }

        // 	Method GetOldestPet() – returns the oldest Pet.
        public Pet GetOldestPet()
        {
            Pet oldestPet = pets.OrderByDescending(x => x.Age).First();
            return oldestPet;
        }

        // •	GetStatistics() – returns a string in the following format:
        //"The clinic has the following patients:
        //     Pet {Name } with owner: {Owner}

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The clinic has the following patients:");

            foreach (var pet in pets)
            {
                sb.AppendLine($"Pet {pet.Name} with owner: {pet.Owner}");
            }

            return sb.ToString().TrimEnd();
        }
    }

}
