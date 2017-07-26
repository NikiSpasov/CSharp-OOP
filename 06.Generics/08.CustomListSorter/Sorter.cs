using System;
using System.Collections.Generic;


public class Sorter<T> : Box<T>
{
    public static void Sort()
    {
        CustomList.Sort();
    }

    public int CompareTo(Sorter<T> other)
    {
        throw new NotImplementedException();
    }

    public Sorter(T anyType) : base(anyType)
    {

    }
}
