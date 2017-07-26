
using System;
using System.Collections;
using System.Collections.Generic;

public class Stack<T> : IEnumerable<T>
{
    private List<T> listOfElements;

    public Stack()
    {
        listOfElements = new List<T>();
    }

    public void Push(T[] args)
    {
        foreach (var param in args)
        {
           listOfElements.Add(param);
        }
    }

    public void Pop()
    {
        try
        {
            listOfElements.RemoveAt(listOfElements.Count - 1);
        }
        catch (Exception e)
        {
            Console.WriteLine("No elements");
        }
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < 2; i++)
        {
            for (int j = listOfElements.Count -1; j >= 0; j--)
            {
                yield return listOfElements[j];
            }
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

