using System;
using System.Collections.Generic;
using System.Text;

namespace _08.Threeuple
{
   public class Threeuple<TFirst, TSecond, TThitd>
    {
        public TFirst ItemOne { get; set; }
        public TSecond ItemTwo { get; set; }
        public TThitd ItemThree { get; set; }

        public Threeuple(TFirst firstItem, TSecond secondItem, TThitd thirdItem)
        {
            ItemOne = firstItem;
            ItemTwo = secondItem;
            ItemThree = thirdItem;
        }

        public override string ToString()
        {
            return $"{ItemOne} -> {ItemTwo} -> {ItemThree}";
        }

    }
}
