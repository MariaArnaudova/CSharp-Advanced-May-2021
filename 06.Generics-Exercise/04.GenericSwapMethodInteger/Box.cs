using System;
using System.Collections.Generic;
using System.Text;

namespace _04.GenericSwapMethodInteger
{
    public class Box<T>
    {

        private List<T> elements;

        public Box(List<T> sequence)
        {
            elements = sequence;
        }

        public int FirstIndex { get; set; }
        public int SecondIndex { get; set; }
        public void Swap(int firstIndex, int secondIndex)
        {
            T currentElement = this.elements[firstIndex];
            this.elements[firstIndex] = this.elements[secondIndex];
            this.elements[secondIndex] = currentElement;
        }

        public override string ToString()
        {
            StringBuilder print = new StringBuilder();
            foreach (T element in elements)
            {
                print.AppendLine($"{element.GetType()}: {element}");
            }
            return print.ToString().TrimEnd();
        }
    }
}
