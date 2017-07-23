
using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<string> stringList = new List<string>();

        for (int i = 0; i < n; i++)
        {
            string text = Console.ReadLine();
            stringList.Add(text);
        }
        string toCompare = Console.ReadLine();

        Console.WriteLine(Box<int>.CompareAndCount(stringList, toCompare));

    }
}

