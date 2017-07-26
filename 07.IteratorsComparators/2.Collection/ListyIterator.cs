using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

public class ListyIterator<T> : IEnumerable<T>
{
    private readonly List<string> items;
    private int internalIndex = 0;

    public ListyIterator(string[] items)
    {
        this.items = new List<string>();
        this.items = items.ToList();
    }

    public int InternalIndex
    {
        get => this.internalIndex;
        set => this.internalIndex = value;
    }

    public bool MoveIndex()
    {
        if (internalIndex < items.Count - 1)
        {
            internalIndex++;
            return true;
        }
        return false;
    }

    public bool HasNext()
    {
        if (internalIndex < items.Count - 1)
        {
            return true;
        }
        return false;
    }

    public IEnumerator<string> GetEnumerator()
    {
       return (IEnumerator<string>) new ListEnumerator(items);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Print()
    {
        try
        {
            Console.WriteLine(items[internalIndex]);
        }
        catch (Exception e)
        {
            Console.WriteLine("Invalid Operation!");
        }

    }

    public void PrintAll()
    {
        try
        {
            Console.WriteLine(string.Join(" ", items));
        }
        catch (Exception e)
        {
            Console.WriteLine("Invalid Operation!");
        }
    }

    IEnumerator<T> IEnumerable<T>.GetEnumerator()
    {
        return (IEnumerator<T>)GetEnumerator();
    }

    private class ListEnumerator : IEnumerator<string>
    {
        private List<string> list;
        public int currentIndex = -1;

        public ListEnumerator(List<string> list)
        {
            this.list = list;
        }

        public void Dispose() { }

        public bool MoveNext() => ++currentIndex < list.Count;

        public void Reset()
        {
            currentIndex = -1;
        }

        public object Current { get; }

        string IEnumerator<string>.Current => this.Current.ToString();
    }
}




