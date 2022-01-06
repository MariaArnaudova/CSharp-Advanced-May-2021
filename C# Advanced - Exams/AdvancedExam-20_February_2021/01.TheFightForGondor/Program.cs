using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.TheFightForGondor
{
    class Program
    {
        static void Main(string[] args)
        {
            int wavesNumber = int.Parse(Console.ReadLine());

            List<int> plates = Console.ReadLine().Split().Select(int.Parse).ToList();
            bool orcsIsWin = false;
   
            Stack<int> wave = new Stack<int>();
            int countPlates = plates.Count;

            for (int i = 0; i < wavesNumber; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (plates.Count <= 0)
                {
                    break;
                }
                wave = new Stack<int>();

                if ((i + 1) % 3 == 0 && i != 0)
                {
                    int needPlate = int.Parse(Console.ReadLine());
                    plates.Add(needPlate);
                    countPlates = plates.Count;
                }

                for (int j = 0; j < input.Length; j++)
                {
                    wave.Push(input[j]);
                }

                for (int k = 0; k < wave.Count; k++)
                {
                    int orc = wave.Peek();

                    for (int f = 0; f < countPlates; f++)
                    {               
                        if (orc > plates[f])
                        {
                            wave.Pop();
                            orc -= plates[f];
                            wave.Push(orc);
                            plates.Remove(plates[f]);
                            countPlates--;
                            f -= 1;
                        }
                        else if (plates[f] > orc)
                        {
                            plates[f] -= orc;
                            wave.Pop();
                            k--;
                            break;
                        }
                        else if (plates[f] == orc)
                        {
                            wave.Pop();
                            plates.Remove(plates[f]);
                            countPlates--;
                            f -= 1;
                            k--;
                            break;
                        }

                        if (plates.Count <= 0)
                        {
                            orcsIsWin = true;
                            break;
                        }
                    }
                    if (orcsIsWin)
                    {
                        break;
                    }
                }
                if (orcsIsWin)
                {
                    break;
                }
            }

            if (plates.Count <= 0)
            {
                Console.WriteLine($"The orcs successfully destroyed the Gondor's defense.");
                Console.WriteLine($"Orcs left: {string.Join(", ", wave)}");
            }
            else
            {
                Console.WriteLine($"The people successfully repulsed the orc's attack.");
                Console.WriteLine($"Plates left: {string.Join(", ", plates)}");
            }
        }

    }
}
