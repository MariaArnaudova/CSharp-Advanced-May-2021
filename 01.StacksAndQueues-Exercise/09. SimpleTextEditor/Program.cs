using System;
using System.Collections.Generic;
using System.Text;

namespace _09._SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int countCommands = int.Parse(Console.ReadLine());

            Stack<string> stack = new Stack<string>();          
            string text = String.Empty;
            stack.Push(text);

            for (int i = 0; i < countCommands; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(new string[] {"", " "}, StringSplitOptions.RemoveEmptyEntries);

                string command = tokens[0];

                switch (command)
                {
                    case "1":
                       
                        for (int j = 1; j < tokens.Length; j++)
                        {
                            text += tokens[j];
                        }
                        stack.Push(text);
                        break;

                    case "2":

                        int numberEraseElements = int.Parse(tokens[1]);
                        //text = text.Substring(0,text.Length-numberEraseElements);
                        
                        int startIndexToRemove = text.Length - numberEraseElements;
                        text = text.Remove(startIndexToRemove, numberEraseElements);
                        stack.Push(text);
                        break;

                    case "3":
                        int index = int.Parse(tokens[1]);
                        text = stack.Peek();

                        Console.WriteLine(text[index -1]);
                        break;

                    case "4":
                        if (stack.Count > 0)
                        {
                            stack.Pop();
                            text = stack.Peek();
                        }           
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
