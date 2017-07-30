using System;

public struct Dog
{
    public string Name { get; set; }

    //in struct there always have to be enpty ctor

    public void Hello()
    {
        Console.WriteLine("Hi Dog");
    }

    //in the struct values are non-referent type, if pass it to 
    //a method - they COPY same value, but inital value DOESN'T change 
}

