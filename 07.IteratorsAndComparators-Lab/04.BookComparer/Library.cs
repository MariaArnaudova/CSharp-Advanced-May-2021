using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        private readonly SortedSet<Book> books;
        public Library(params Book[] books)
        {
            this.Books = new SortedSet<Book>(books, new BookComparator());
            //this.Books = books.ToList();
        }

        //public List<Book> Books { get; private set; }  
        public SortedSet<Book> Books { get; private set; }  

        public IEnumerator<Book> GetEnumerator()
        {
            //Books.Sort();
            return new LibraryIterator(Books.ToList());
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class LibraryIterator : IEnumerator<Book>
        {
            private int index = -1;
            public LibraryIterator(List<Book> books)
            {
                this.Books = books;

            }

            public List<Book> Books { get; set; }
            public Book Current => Books[index];

            object IEnumerator.Current => Books[index];

            public void Dispose() { }

            public bool MoveNext()
            {
                return ++index < Books.Count;
            }

            public void Reset()
            {
                index = -1;
            }
        }
    }
}
