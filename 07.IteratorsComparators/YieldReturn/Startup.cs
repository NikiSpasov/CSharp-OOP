using System;
using System.Collections.Generic;
using YieldReturn;

public class Startup

{
    public static void Main()
    {
        CatCollectionWithYeld cats = new CatCollectionWithYeld(new List<Cat>
        {
           new Cat(){Age = 10, Name = "Marin"},
           new Cat(){Age = 1, Name = "Marina"},
           new Cat(){Age = 5, Name = "Mareto"},
           new Cat(){Age = 10, Name = "Spas"},
        });

        foreach (var cat in cats)
        {
            Console.WriteLine(cat.Name);
        }
    }
}

