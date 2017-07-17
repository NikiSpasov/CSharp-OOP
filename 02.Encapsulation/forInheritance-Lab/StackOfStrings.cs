
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

public class StackOfStrings : ArrayList
{
    private List<string> data;

    public List<string> Data
    {
        get { return this.data; }
        set { this.data = value; }
    }

    public StackOfStrings(List<string> data)
    {
        Data = data;
    }

    public void Push(String str)
    {
        Data.Add(str);
    }

    public string Pop()
    {
        string last = Data[Data.Count - 1];
        Data.RemoveAt(Data.Count - 1);
        return last;
    }

    public string Peek()
    {
        return Data[Data.Count - 1];
    }

    public bool IsEmpty()
    {
        if (Data.Count == 0)
        {
            return true;
        }
        return false;
    }

}

