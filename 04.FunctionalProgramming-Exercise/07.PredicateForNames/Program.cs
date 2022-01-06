using System;
using System.Linq;

namespace _07.PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            Func<string, bool> namesLength = name => name.Length <= n;

            Action<string[]> print = numbers => Console.WriteLine(String.Join(Environment.NewLine, numbers));

            string[] names = Console.ReadLine()
                .Split()
               .Where(namesLength)
               .ToArray();

            print(names);
        }
    }
}
