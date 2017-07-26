using System;
using System.ComponentModel;

public class Tuple<T>
{
    private T item1;
    private T item2;

    public T Item1
    {
        get => item1;
        set { this.item1 = value; }
    }

    public T Item2
    {
        get => item2;
        set { this.item2 = value; }
    }

    public Tuple(T item1, T item2)
    {
        Item1 = item1;
        Item2 = item2;
    }

    public void Write()
    {
        Console.WriteLine($"{Item1} -> {Item2}");
    }
}

