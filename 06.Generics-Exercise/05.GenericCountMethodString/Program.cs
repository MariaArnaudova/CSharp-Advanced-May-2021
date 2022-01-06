using System;
using System.Collections.Generic;

namespace _05.GenericCountMethodString
{
   public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> elements = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string element = Console.ReadLine();
                elements.Add(element);
            }

            string elementToCompare = Console.ReadLine();

            Box<string> box = new Box<string>(elements);

           int countElement = box.CountOfGreaterElements(elements, elementToCompare);

            Console.WriteLine(countElement);
        }

    }
}
