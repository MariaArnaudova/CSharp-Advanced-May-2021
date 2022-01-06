using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ActionPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Action<string[]> print = items => Console.WriteLine(String.Join(Environment.NewLine, items));
            print(input);


            //Action<List<string>> print = item => Console.WriteLine(item);

            //List<string> input = Console.ReadLine()
            //  .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            //  .ToList();

            //print(input);

        }
    }
}
