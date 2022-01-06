using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int queries = int.Parse(Console.ReadLine());

            Stack<int> stackElement = new Stack<int>();

            for (int i = 0; i < queries; i++)
            {
                string[] currentQuery = Console.ReadLine()
                    .Split();

                string query = currentQuery[0];

                if (query == "1")
                {
                    int element = int.Parse(currentQuery[1]);
                    stackElement.Push(element);
                }
                else if (query == "2")
                {
                    if (stackElement.Count > 0)
                    {
                        stackElement.Pop();
                    }
                }
                else if (query == "3")
                {
                    if (stackElement.Count > 0)
                    {
                        int maxElement = stackElement.Max();
                        Console.WriteLine(maxElement);
                    }                  
                }
                else if (query == "4")
                {
                    if (stackElement.Count > 0)
                    {
                        int minElement = stackElement.Min();
                        Console.WriteLine(minElement);
                    }               
                }
            }
            Console.WriteLine(String.Join(", ", stackElement));
        }
    }
}
