using System;
using System.Collections;
using System.Collections.Generic;

namespace IterratorsComparators
{
    public class BooksCollection : IEnumerable<Book> //foreach returns type between <>
    {
        private readonly List<Book> books;

        public BooksCollection()
        {
            this.books = new List<Book>();
        }

        public void Add(Book book)
        {
            this.books.Add(book);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new BooksEnumerator(this.books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.books.GetEnumerator();
        }
        //HERE, nested class for custom foreach is FINE - it has a tipical structure:
        private class BooksEnumerator : IEnumerator<Book>
        {
            private readonly List<Book> books;

            private int currentIndex = -2;

            public BooksEnumerator(List<Book> books)
            {
                this.books = books;
            }

            public Book Current => this.books[this.currentIndex];

            object IEnumerator.Current => this.Current;

            public void Dispose()
            {
            }

            public bool MoveNext()
            {

                this.currentIndex += 2;
                if (this.currentIndex >= this.books.Count)
                {
                    return false;
                }
                return true;

            }
            public void Reset() => this.currentIndex = -2;
        }

    }

    

}
