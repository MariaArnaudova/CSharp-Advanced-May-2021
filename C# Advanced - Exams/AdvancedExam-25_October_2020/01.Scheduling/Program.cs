using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Scheduling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputTasks = Console.ReadLine()
                 .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            int[] inputThreads = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int taskToBeKilled = int.Parse(Console.ReadLine());

            Stack<int> task = new Stack<int>(inputTasks);
            Queue<int> thread = new Queue<int>(inputThreads);
            bool isStopCpu = false;

            while (true)
            {
                int currentThread = thread.Peek();
                int currentTask = task.Peek();
                if ( currentTask == taskToBeKilled)
                {
                    task.Pop();
                    isStopCpu = true;
                    break;
                }
                if (currentThread >= currentTask)
                {
                    task.Pop();
                    thread.Dequeue();
                }
                else if (currentThread < currentTask)
                {
                    thread.Dequeue();
                }
            }

            if (isStopCpu)
            {
                Console.WriteLine($"Thread with value {thread.Peek()} killed task {taskToBeKilled}");
                Console.WriteLine(String.Join(" ", thread));
            }
        }
    }
}
