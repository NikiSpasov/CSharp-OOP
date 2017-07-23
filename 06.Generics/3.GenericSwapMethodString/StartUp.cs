using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<Box<string>> TextList = new List<Box<string>>();

        for (int i = 0; i < n; i++)
        {
            Box<string> text = new Box<string>(Console.ReadLine());
            TextList.Add(text);
        }

        int[] numsForSwap = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        Box<string>.Swap(TextList, numsForSwap[0], numsForSwap[1]);

        foreach (var txt in TextList)
        {
            Console.WriteLine(txt.ToString());
        }
    }
}
