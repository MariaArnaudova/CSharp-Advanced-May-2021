using System;
using System.Collections.Generic;
using System.Text;

namespace _06.GenericCountMethodDouble
{
   public class Box<T> where T: IComparable
    {
        private List<T> elements;

        public Box(List<T> sequence)
        {
            this.elements = sequence;
        }

        public int CountOfGreaterElements(List<T> elements, T comapareElement)
        {
            int count = 0;
            foreach (T element in elements)
            {
                if (comapareElement.CompareTo(element) < 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
