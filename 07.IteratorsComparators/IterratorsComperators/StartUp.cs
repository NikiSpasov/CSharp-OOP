using System;
using System.Collections;
using System.Collections.Generic;

namespace IterratorsComparators
{
    public class StartUp
    {
        public static void Main()
        {

            BooksCollection books = new BooksCollection();
            books.Add(new Book {Title = "Deo"});
            books.Add(new Book {Title = "Teo"});
            books.Add(new Book {Title = "Geo"});
            books.Add(new Book {Title = "Zeo"});
            books.Add(new Book {Title = "Xeo"});
            books.Add(new Book {Title = "Peo"});
            books.Add(new Book {Title = "Reo"});

            foreach (var book in books)
            {
                Console.WriteLine(book.Title);
            }
        }

        //Structure iof IEnumerator

        public interface IEnumerator<T> : IEnumerator
        {
            bool MoveNext(); //how to go to next and is there next element
            void Reset(); // how to reset
            T Current { get; } // wich is current element 
        }




        // IEnumerable<T> - това е колекцията, която съдържа елементите и може да се foreach-ва
        // IЕnumerator<T> - как може тези елементи да бъдат итерирани
        // IEnumerator is sequential readOnly, forward only
    }
}
