
using System;

public class Bunny: IMammal
{
    public string Name { get; }
    public int Age { get; }

    public string MakeNoise()
    {
        throw new System.NotImplementedException();
    }

    public void SayIamAMammal()
    {
        Console.WriteLine("I'm a mammal");
    }
}

