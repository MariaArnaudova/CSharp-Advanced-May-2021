using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            // bomb effects and bomb casings.
            int[] bobmEffects = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] bobmCasings = Console.ReadLine()
               .Split(", ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();

            Queue<int> effects = new Queue<int>(bobmEffects);
            Stack<int> casings = new Stack<int>(bobmCasings);
            int sum = 0;

            int dataBombs = 40;
            int cheryBombs = 60;
            int smokeDecoyBombs = 120;

            Dictionary<string, int> bombPouch = new Dictionary<string, int>();

            string daturaBomb = "Datura Bombs";
            string cherryBomb = "Cherry Bombs";
            string smokeDecoyBomb = "Smoke Decoy Bombs";

            bombPouch.Add(daturaBomb, 0);
            bombPouch.Add(cherryBomb, 0);
            bombPouch.Add(smokeDecoyBomb, 0);



            while (effects.Count != 0 && casings.Count != 0)
            {
                int currentEffect = effects.Peek();
                int currentCasing = casings.Pop();

                sum = currentEffect + currentCasing;

                if (sum == dataBombs)
                {
                    bombPouch["Datura Bombs"]++;
                    effects.Dequeue();
                }
                else if (sum == cheryBombs)
                {
                    bombPouch["Cherry Bombs"]++;
                    effects.Dequeue();
                }
                else if (sum == smokeDecoyBombs)
                {
                    bombPouch["Smoke Decoy Bombs"]++;
                    effects.Dequeue();
                }
                else
                {
                    casings.Push(currentCasing - 5);
                }

                if (!bombPouch.Any(x => x.Value < 3))
                {
                    break;
                }
            }

            bool isThreeOfEachBomb = bombPouch.Any(x => x.Value < 3);

            if (isThreeOfEachBomb)
            {
                Console.WriteLine($"You don't have enough materials to fill the bomb pouch.");
            }
            else
            {
                Console.WriteLine($"Bene! You have successfully filled the bomb pouch!");
            }

            if (effects.Count == 0)
            {
                Console.WriteLine($"Bomb Effects: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Effects: {String.Join(", ", effects)}");
            }


            if (casings.Count == 0)
            {
                Console.WriteLine($"Bomb Casings: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Casings: {String.Join(", ", casings)}");
            }

            bombPouch = bombPouch.OrderBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);

            foreach (var bomb in bombPouch)
            {
                Console.WriteLine($"{bomb.Key}: {bomb.Value}");
            }
        }
    }
}
