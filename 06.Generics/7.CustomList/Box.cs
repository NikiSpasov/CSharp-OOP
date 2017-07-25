
using System;
using System.Collections.Generic;
using System.Linq;

public class Box<T> : IComparable<Box<T>>
{
    private T myVar;

    public List<string> CustomList;

    public Box(T anyType)
    {
        this.myVar = anyType;
        CustomList = new List<string>();
    }

    public void Max()
    {
        Console.WriteLine(CustomList.Max());
    }

    public void Min()
    {
        Console.WriteLine(CustomList.Min());
    }

    public void Print()
    {
        foreach (var obj in CustomList)
        {
            Console.WriteLine(obj);
        }
    }

    public void Add(string element)
    {
        CustomList.Add(element);
    }

    public string Remove(int index)
    {
        string toReturn = CustomList[index];
        CustomList.RemoveAt(index);
        return toReturn;
    }

    public bool Contains(string element)
    {
        if (CustomList.Contains(element))
        {
            return true;
        }
        return false;
    }

    public void Swap(int firstIndex, int secondIndex)
    {
        var first = CustomList[firstIndex];
        var second = CustomList[secondIndex];
        CustomList[firstIndex] = second;
        CustomList[secondIndex] = first;
    }

    public override string ToString()
    {
        return $"{myVar.GetType().FullName}: {myVar}";
    }

    public int CompareTo(object obj)
    {
        throw new NotImplementedException();
    }

    public int CountGreaterThan<T>(T element)
        where T : IComparable
    {
        int cnt = 0;
        foreach (var item in CustomList)
        {
            if (item.CompareTo(element) > 0)
            {
                cnt++;
            }
        }
        return cnt;
    }

    public int CompareTo(Box<T> other)
    {
        if (other.GetType() != GetType())
            return -1;
        return CompareTo(other);
    }
}

