using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Cooking
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] liquidInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] ingredientsInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int bread = 25;
            int cake = 50;
            int pastry = 75;
            int fruitPie = 100;

            Queue<int> liquids = new Queue<int>(liquidInput);
            Stack<int> ingredients = new Stack<int>(ingredientsInput);

            Dictionary<string, int> products = new Dictionary<string, int>();

            products.Add("Bread", 0);
            products.Add("Cake", 0);
            products.Add("Fruit Pie", 0);
            products.Add("Pastry", 0);

            string product = "";
            int amountProduct = 0;

            while (true)
            {
                int currentLiquid = liquids.Peek();
                int currentIngredient = ingredients.Peek();

                int sumIngredients = currentLiquid + currentIngredient;

                if (sumIngredients == bread)
                {
                        products["Bread"] ++;
               
                    liquids.Dequeue();
                    ingredients.Pop();
                }
                else if (sumIngredients == cake)
                {
                    products["Cake"]++;
                    
                    liquids.Dequeue();
                    ingredients.Pop();
                }
                else if (sumIngredients == pastry)
                {
                    products["Pastry"]++;
                  
                    liquids.Dequeue();
                    ingredients.Pop();
                }
                else if (sumIngredients == fruitPie)
                {
                    products["Fruit Pie"]++;
                   
                    liquids.Dequeue();
                    ingredients.Pop();
                }
                else
                {
                    liquids.Dequeue();
                    ingredients.Push(ingredients.Pop() + 3);
                }

                if (liquids.Count == 0 || ingredients.Count == 0)
                {

                    break;
                }
            }

            bool cookedAllProducts = false;
            cookedAllProducts = products.Any(x => x.Value == 0);

            products = products.OrderBy(x=>x.Key).ToDictionary(x=>x.Key, y=>y.Value);

            if (!cookedAllProducts)
            {
                Console.WriteLine($"Wohoo! You succeeded in cooking all the food!");
            }
            else           
            {
                Console.WriteLine($"Ugh, what a pity! You didn't have enough materials to cook everything.");
            }

            if (liquids.Count <= 0)
            {
                Console.WriteLine($"Liquids left: none");
            }
            else
            {
                Console.WriteLine($"Liquids left: {String.Join(", ", liquids)}");
            }

            if (ingredients.Count <= 0)
            {
                Console.WriteLine($"Ingredients left: none");
            }
            else
            {
                Console.WriteLine($"Ingredients left: {string.Join(", ", ingredients)}");
            }

            foreach (var finalProduct in products)
            {
                Console.WriteLine($"{finalProduct.Key}: {finalProduct.Value}");
            }
        }
    }
}
