using System;
using System.Collections;
using System.Collections.Generic;

public class Startup
{
    public static void Main()
    {
        Book bookOne = new Book("Animal Farm", 2003, "George Orwell");
        Book bookTwo = new Book("The Documents in the Case", 2002, "Dorothy Sayers", "Robert Eustace");
        Book bookThree = new Book("The Documents in the Case", 1930);

        var libr = new Library(bookOne, bookTwo, bookThree);
      
        
        foreach (var book in libr)
        {
            Console.WriteLine(book);
        }

    }
}

