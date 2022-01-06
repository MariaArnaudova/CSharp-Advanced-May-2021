using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            string gest = Console.ReadLine();
            HashSet<string> listGest = new HashSet<string>();

            while (gest != "PARTY")
            {
                listGest.Add(gest);
                gest = Console.ReadLine();
            }

            while (true)
            {
                string commingGest = Console.ReadLine();
                if (commingGest == "END")
                {
                    break;
                }
                if (listGest.Contains(commingGest))
                {
                    listGest.Remove(commingGest);
                }              
            }
            Console.WriteLine(listGest.Count());

            listGest = listGest./*Where(g => g[0] < 65).*/OrderByDescending(g => g[0] < 65).ToHashSet();
            foreach (var lastGest in listGest)
            {
                Console.WriteLine(lastGest);
            }

            listGest = listGest.Select(g => g[0] < 65).ToHashSet();

            
        }
    }
}
