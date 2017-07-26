using System.Collections.Generic;
using System.Linq;

public class Book
{
    public string Title;
    public int Year;
    public List<string> Authors;

    public Book(string title, int year, params string[] authors)
    {
        this.Title = title;
        this.Year = year;
        this.Authors = authors.ToList();
    }
}

