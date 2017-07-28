using System;
using System.Collections.Generic;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        List<int> stones = Console.ReadLine()
            .Split(new[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();
        Lake froggyLake = new Lake(stones);

        Console.WriteLine(String.Join(", ", froggyLake));     
    }
}

