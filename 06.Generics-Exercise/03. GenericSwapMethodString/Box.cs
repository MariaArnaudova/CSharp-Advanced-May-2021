using System;
using System.Collections.Generic;
using System.Text;

namespace _03._GenericSwapMethodString
{
   public class Box<T>
    {

        private List<T> values;

        public Box(List<T> values)
        {
            this.values = values;
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            T currentElement = this.values[firstIndex];
          this.values[firstIndex] = this.values[secondIndex];
            this.values[secondIndex] = currentElement;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach   (T value in values)
            {
                sb.AppendLine($"{ value.GetType()}: {value}");    
            }
            return sb.ToString().TrimEnd();
        }
    }
}
