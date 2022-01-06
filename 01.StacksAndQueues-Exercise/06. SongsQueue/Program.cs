using System;
using System.Collections.Generic;

namespace _06._SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ");

            Queue<string> queueSongs = new Queue<string>(songs);

            while (queueSongs.Count > 0)
            {
                string commands = Console.ReadLine();

                if (commands.Contains("Play"))
                {
                    queueSongs.Dequeue();
                }
                else if (commands.Contains("Add"))
                {

                    string song = commands.Substring(4, commands.Length - 4);

                    if (!queueSongs.Contains(song))
                    {
                        queueSongs.Enqueue(song);
                    }
                    else
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                }
                else if (commands.Contains("Show"))
                {
                    Console.WriteLine(String.Join(", ", queueSongs));
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}
