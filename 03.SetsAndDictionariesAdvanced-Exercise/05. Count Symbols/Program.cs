using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Dictionary<char, int> charOccurrences = new Dictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (!charOccurrences.ContainsKey(text[i]))
                {
                    charOccurrences.Add(text[i], 1);
                }
                else
                {
                    charOccurrences[text[i]]++;
                }
            }

            charOccurrences = charOccurrences.OrderBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value); ;

            foreach (var currentChar in charOccurrences)
            {
                Console.WriteLine($"{currentChar.Key}: {currentChar.Value} time/s");
            }
        }
    }
}
