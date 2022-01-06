using System;
using System.Collections.Generic;
using System.Text;

namespace _01.ListyIterator
{
    public class ListyIterator<T>
    {
        private List<T> colection;

        private int currentIndex;

        public ListyIterator(params T[] data)
        {
            colection = new List<T>(data);
            currentIndex = 0;
        }

        public List<T> List => colection;

        public bool HasNext() => currentIndex < colection.Count - 1;

        public bool Move()
        {
            bool canMove = this.HasNext();

            if (canMove)
            {
                currentIndex++;
            }
            return canMove;
        }

        public void Print()
        {
            if (colection.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            Console.WriteLine($"{colection[currentIndex]}");
        }
    }
}
