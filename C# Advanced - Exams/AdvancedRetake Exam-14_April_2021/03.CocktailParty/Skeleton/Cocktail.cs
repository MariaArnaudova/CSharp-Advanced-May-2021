using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CocktailParty
{
    public class Cocktail
    {
        //private List<Ingredient> ingredients;

        public Cocktail(string name, int capacity, int maxAlcoholLevel)
        {
            this.Ingredients = new List<Ingredient>();
            this.Name = name;
            this.Capacity = capacity;
            this.MaxAlcoholLevel = maxAlcoholLevel;
        }
        // Getter CurrentAlcoholLevel – returns the amount of alcohol currently in the cocktail.
        public int CurrentAlcoholLevel
        {
            get
            {
                return Ingredients.Sum(i => i.Alcohol);
            }
        }
        public List<Ingredient> Ingredients { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int MaxAlcoholLevel { get; set; }


        //•	Method Add(Ingredient ingredient) - adds the entity 
        //if there isn't an Ingredient with the same name and if there is enough space in terms of quantity and alcohol.
        public void Add(Ingredient ingredient)
        {
            bool isSameIngredient = Ingredients.Any(x => x.Name == ingredient.Name);
            //if (!Ingredients.Any(x => x.Name == ingredient.Name
            //    && ingredient.Quantity <= this.Capacity
            //    && ingredient.Alcohol <= this.MaxAlcoholLevel))
            //{
            //    Ingredients.Add(ingredient);
            //    Capacity -= ingredient.Quantity;
            //    MaxAlcoholLevel -= ingredient.Alcohol;
            //}
            if (!isSameIngredient)
            {
                if (Ingredients.Count <= Capacity
                    && ingredient.Alcohol + CurrentAlcoholLevel <= MaxAlcoholLevel)
                {
                    Ingredients.Add(ingredient);
                    Capacity -= ingredient.Quantity;
                    MaxAlcoholLevel -= ingredient.Alcohol;
                }
            }

        }

        // Method Remove(string name) - removes an Ingredient from the cocktail with the given name, 
        // if such exists and returns bool if the deletion is successful.
        public bool Remove(string name)
        {
            bool isSameIngredient = Ingredients.Any(x => x.Name == name);
            if (isSameIngredient)
            {
                Ingredient removerdIngredient = Ingredients.FirstOrDefault(i => i.Name == name);
                MaxAlcoholLevel += removerdIngredient.Alcohol;
                Capacity += removerdIngredient.Quantity;
                Ingredients.Remove(removerdIngredient);
                return true;
            }
            return false;
        }
        //Method FindIngredient(string name) - 
        // returns an Ingredient with the given name.If it doesn't exist, return null.

        public Ingredient FindIngredient(string name)
        {
            Ingredient foundIngredient = Ingredients.Where(i => i.Name == name).FirstOrDefault();
            if (foundIngredient != null)
            {
                return foundIngredient;
            }
            return null;
        }
        //	Method GetMostAlcoholicIngredient() – returns the Ingredient with most Alcohol.
        public Ingredient GetMostAlcoholicIngredient()
        {
            Ingredient foundIngredient = Ingredients.OrderByDescending(x => x.Alcohol).FirstOrDefault();
            return foundIngredient;
        }

        // Method Report() - returns information 
        // about the Cocktail and the Ingredients inside it in the following format:

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cocktail: {this.Name} - Current Alcohol Level: { this.CurrentAlcoholLevel}");
            sb.AppendLine(String.Join(Environment.NewLine, Ingredients));

            return sb.ToString().TrimEnd();
        }
    }
}
