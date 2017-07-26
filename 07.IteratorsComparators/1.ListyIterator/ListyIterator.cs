using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class ListyIterator<T> : IEnumerable<T>
{
    private List<string> items;
    private int internalIndex = 0;

    public ListyIterator(string[] items)
    {
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

    public bool HasNext ()
    {
        if (internalIndex < items.Count - 1)
        {
            return true;
        }
        return false;     
	}
    
    public IEnumerator<T> GetEnumerator()
    {
        throw new System.NotImplementedException();
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
}



