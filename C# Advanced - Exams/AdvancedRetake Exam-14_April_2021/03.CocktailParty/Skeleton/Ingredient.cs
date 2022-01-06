using System;
using System.Collections.Generic;
using System.Text;

namespace CocktailParty
{
    public class Ingredient
    {
        public Ingredient(string name, int alcohol, int quantity)
        {
            this.Name = name;
            this.Alcohol = alcohol;
            this.Quantity = quantity;
        }
        public string Name { get; set; }
        public int Alcohol { get; set; }
        public int Quantity { get; set; }

        public override string ToString()
        {
            StringBuilder print = new StringBuilder();

            print.AppendLine($"Ingredient: {this.Name}");
            print.AppendLine($"Quantity: { this.Quantity}");
            print.Append($"Alcohol: {this.Alcohol}");
            return print.ToString().TrimEnd();
        }
    }
}
