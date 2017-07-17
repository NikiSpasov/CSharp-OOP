
using System;

public class Mouse : Mammal
{
    public override void Eat(Food food)
    {
        throw new NotImplementedException();
    }

    public override void MakeSound()
    {

        Console.WriteLine("SQUEEEAAAK!");

    }

    public Mouse(string animalType, string animalName, double animalWeight, string livingRegion) : base(animalType, animalName, animalWeight, livingRegion)
    {
    }
}

