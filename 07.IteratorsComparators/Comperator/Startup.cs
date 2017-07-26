using System;
using System.Collections.Generic;

namespace Comperator
{
    public class Startup
    {
        public static void Main()
        {
           var sortedSet = new SortedSet<Book>();
            sortedSet.Add(new Book {Author = "Pesho", Name = "Te pa toa"});
            sortedSet.Add(new Book {Author = "Pesho", Name = "Ae pa toa"});
            sortedSet.Add(new Book {Author = "Besho", Name = "We pa toa"});
            sortedSet.Add(new Book {Author = "Nesho", Name = "We pa toa"});
            sortedSet.Add(new Book {Author = "Aesho", Name = "Ye pa toa"});
            sortedSet.Add(new Book {Author = "Bieesho", Name = "Ue pa toa"});
            foreach (var book in sortedSet)
            {
                Console.WriteLine("{0} -> {1}", book.Name, book.Author);
            }
            var anotherSet = new SortedSet<Book>(new BookComparerer());

        }
    }
}
