using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] expession = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Stack<string> elements = new Stack<string>();

            for (int i = expession.Length-1; i >= 0; i--)
            {
                elements.Push(expession[i]);
            }
 
            int result = 0;

            while (elements.Count > 1)
            {
                int firstNum = int.Parse(elements.Pop());
                string operand = elements.Pop();
                int secondNum = int.Parse(elements.Pop());

                if (operand == "+")
                {
                    result = firstNum + secondNum;
                }
                else if (operand == "-")
                {
                    result = firstNum - secondNum;
                }

                elements.Push(result.ToString());

            }

            Console.WriteLine(result);


            //while (elements.Count > 1)
            //{
            //    string element = elements.Pop();
                
            //    if (element == "+")
            //    {
            //        int number = int.Parse(elements.Pop());
            //        result = result + number;
            //    }
            //    else if (element == "-")
            //    {
            //        int number = int.Parse(elements.Pop());
            //        result = result - number;
            //    }
            //    else
            //    {
            //        result = int.Parse(element);
            //    }

            //    elements.Push(result.ToString());
            //}

            //Console.WriteLine(result);

        }
    }
}
