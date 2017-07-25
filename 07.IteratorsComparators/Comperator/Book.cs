using System;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace Comperator
{
    public class Book : IComparable<Book>
    {
        public string Name { get; set; }
        public string Author { get; set; }



        //HOW TO COMPARE
        public int CompareTo(Book other)
        {
            var authorCompare = this.Author.CompareTo(other.Author);
            var nameCompare = this.Name.CompareTo(other.Name);
            if (authorCompare != 0)
            {
                return authorCompare;
            }
            if (nameCompare != 0)
            {
                return nameCompare;
            }
            return 0;
        }
    }
    public class BookComparerer : IComparer<Book> //this method OVERRIDES "Compare to" method
        //in Book class, but only if we call it explicitly,
        //like var anotherSet = new SortedSet<book>(new BookComparer());
    {
        public int Compare(Book x, Book y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
