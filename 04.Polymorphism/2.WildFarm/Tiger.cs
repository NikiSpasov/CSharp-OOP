
using System;

public class Tiger : Felime
{
    public Tiger(string animalType, string animalName, double animalWeight, string livingRegion) : base(animalType, animalName, animalWeight, livingRegion)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine("ROAAR");
    }
}

