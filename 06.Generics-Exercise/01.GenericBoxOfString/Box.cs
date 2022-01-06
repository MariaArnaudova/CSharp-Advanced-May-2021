using System;
using System.Collections.Generic;
using System.Text;

namespace _01.GenericBoxOfString
{
   public class Box<T>
    {
        private T value;
        public Box(T value)
        {
            this.value = value;
        }

        public override string ToString()
        {
            return $"{this.value.GetType()}: {value}";
        }
    }
}
