using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Library : IEnumerable<Book>

{
    private readonly SortedSet<Book> books;

    public Library(params Book[] zeroOneOrMany)
    {
        books = new SortedSet<Book>(new BookComparator());
        foreach (var book in zeroOneOrMany)
        {
            books.Add(book);
        }
    }

    public IEnumerator<Book> GetEnumerator()
    {
        return new LibraryIterator(this.books);
    }

    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();


    private class LibraryIterator : IEnumerator<Book>
    {
        private readonly List<Book> books;
        private int currentIndex = -1;

        public LibraryIterator(IEnumerable<Book> books)
        {
            this.Reset();
            this.books = new List<Book>(books);
        }

        public void Dispose(){}

        public bool MoveNext() => ++currentIndex < books.Count;
        public void Reset() => this.currentIndex = -1;
        public Book Current => this.books[currentIndex];
        object IEnumerator.Current => this.Current;

    }
}

