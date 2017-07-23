
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

}

