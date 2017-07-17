using System;
using System.Collections.Generic;

public class StartUp
{
    public static void Main()
    {
        List<string> test = new List<string>
        {
            "Gosho",
            "Pesho",
            "Ivan"
        };

        StackOfStrings newstack = new StackOfStrings(test);
        newstack.Peek();
        newstack.IsEmpty();
        newstack.Pop();
        newstack.Push("aas");
    }
}

