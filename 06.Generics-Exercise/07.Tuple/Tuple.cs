using System;
using System.Collections.Generic;
using System.Text;

namespace _07.Tuple
{
    public class Tuple<TFirst, TSecond>
    {
        public TFirst ItemOne { get; set; }
        public TSecond ItemTwo { get; set; }

        public Tuple(TFirst firstItem, TSecond secondItem)
        {
            ItemOne = firstItem;
            ItemTwo = secondItem;
        }

        public override string ToString()
        {
           return $"{ItemOne} -> {ItemTwo}";
        }
    }
}


