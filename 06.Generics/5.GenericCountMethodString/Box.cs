﻿
using System;
using System.Collections.Generic;

public class Box<T>
{
    private T myVar;

    public Box(T anyType)
    {
        this.myVar = anyType;
    }

    public static void Swap<TV>(List<TV> data, int firstIndex, int secondIndex)
    {
        var first = data[firstIndex];
        var second = data[secondIndex];
        data[firstIndex] = second;
        data[secondIndex] = first;
    }

    public override string ToString()
    {
        return $"{myVar.GetType().FullName}: {myVar}";
    }

    public static int CompareAndCount<T>(List<T> data, string element)
        where T : IComparable
    {
        int cnt = 0;
        foreach (var item in data)
        {
            if (item.CompareTo(element) > 0)
            {
                cnt++;
            }
        }

        return cnt;
    }

}

