using System;
using System.Collections.Generic;

namespace _06._Wardrobe
{
    class Program
    {
        public static object Disctionary { get; private set; }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> clothes = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] currentSetInfo = Console.ReadLine().Split(" -> ");
                string color = currentSetInfo[0];
                string[] cloth = currentSetInfo[1].Split(",", StringSplitOptions.RemoveEmptyEntries);

                if (!clothes.ContainsKey(color))
                {
                    clothes.Add(color, new Dictionary<string, int>());
                }
                for (int j = 0; j < cloth.Length; j++)
                {
                    string currentCloth = cloth[j];
                    if (!clothes[color].ContainsKey(currentCloth))
                    {
                        clothes[color].Add(currentCloth, 0);
                    }
                    clothes[color][currentCloth]++;
                }
            }
            string[] typeCloth = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string searchColor = typeCloth[0];
            string searchCloth = typeCloth[1];

            foreach (var color in clothes)
            {
                Console.WriteLine($"{color.Key} clothes:");
                foreach (var cloth in color.Value)
                {
                    //* dress - 1 (found!)
                    if (cloth.Key == searchCloth && searchColor == color.Key)
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
                    }
                }
            }
        }
    }
}
