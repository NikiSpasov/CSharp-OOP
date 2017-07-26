
using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        double n = double.Parse(Console.ReadLine());
        List<double> doubleList = new List<double>();

        for (int i = 0; i < n; i++)
        {
            double num = double.Parse(Console.ReadLine());
            doubleList.Add(num);
        }
        double toCompare = double.Parse(Console.ReadLine());

        Console.WriteLine(Box<int>.CompareAndCount(doubleList, toCompare));

    }
}

