using System;
using System.Collections.Generic;

namespace _06.GenericCountMethodDouble
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<double> elements = new List<double>();

            for (int i = 0; i < n; i++)
            {
                double element = double.Parse(Console.ReadLine());
                elements.Add(element);
            }

            double elementToCompare = double.Parse(Console.ReadLine());

            Box<double> box = new Box<double>(elements);

            int countElement = box.CountOfGreaterElements(elements, elementToCompare);

            Console.WriteLine(countElement);
        }
    }
}
