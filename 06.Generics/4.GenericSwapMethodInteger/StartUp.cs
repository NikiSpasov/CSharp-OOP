using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<Box<int>> intList = new List<Box<int>>();

        for (int i = 0; i < n; i++)
        {
            Box<int> text = new Box<int>(int.Parse(Console.ReadLine()));
            intList.Add(text);
        }
        int[] numsForSwap = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        Box<int>.Swap(intList, numsForSwap[0], numsForSwap[1]);

        foreach (var number in intList)
        {
            Console.WriteLine(number.ToString());
        }
    }
}
