using System;
using System.Collections.Generic;
namespace _4._MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string expresion = Console.ReadLine();

            var brakesIndexes = new Stack<int>();

            for (int i = 0; i < expresion.Length; i++)
            {
                char currentChar = expresion[i];

                if (currentChar == '(')
                {
                    brakesIndexes.Push(i);
                }
                else if (currentChar == ')')
                {
                    int indexCloseBrake = i;
                    int indexOpenBrake = brakesIndexes.Pop();
                    string subExpresion = expresion.Substring(indexOpenBrake, indexCloseBrake - indexOpenBrake + 1);
                    Console.WriteLine(subExpresion);
                }
            }
        }
    }
}
