
using System;

public class Zebra : Mammal
{
    public override void MakeSound()
    {
        Console.WriteLine("Zs");
    }

    public override void Eat(Food food)
    {
        throw new System.NotImplementedException();
    }

    public Zebra(string animalType, string animalName, double animalWeight, string livingRegion) : base(animalType, animalName, animalWeight, livingRegion)
    {
    }
}

