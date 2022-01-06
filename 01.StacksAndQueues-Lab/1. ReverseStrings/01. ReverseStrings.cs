using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Stack<char> newStack = new Stack<char>();

            for (int i = 0; i < text.Length; i++)
            {
                newStack.Push(text[i]);
            }

            while (newStack.Any())
            {
                Console.Write(newStack.Pop());
            }


            //foreach (var item in reverseStack)
            //{
            //    Console.Write(item);
            //}
        }
    }
}
