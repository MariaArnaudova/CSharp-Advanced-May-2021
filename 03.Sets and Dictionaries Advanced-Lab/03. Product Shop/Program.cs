using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] productsInfo = Console.ReadLine().Split(", ");
            Dictionary<string, Dictionary<string, double>> shopsAndProducts = new Dictionary<string, Dictionary<string, double>>();
            while (productsInfo[0]!= "Revision")
            {
                string shop = productsInfo[0];
                string product = productsInfo[1];
                double price = double.Parse(productsInfo[2]);

                if (!shopsAndProducts.ContainsKey(shop))
                {
                    shopsAndProducts.Add(shop, new Dictionary<string, double>());
                }

                if (!shopsAndProducts[shop].ContainsKey(product))
                {
                    shopsAndProducts[shop].Add(product, price);
                }

                productsInfo = Console.ReadLine().Split(", ");
            }

            shopsAndProducts = shopsAndProducts.OrderBy(s => s.Key).ToDictionary(s => s.Key, s => s.Value);

            foreach (var shop in shopsAndProducts)
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
