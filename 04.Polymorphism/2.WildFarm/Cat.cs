
using System;

public class Cat : Felime
{
    private string breed;

    public string Breed
    {
        get { return this.breed; }
        set { this.breed = value; }
    }

    public Cat(string animalType, string animalName, double animalWeight, string livingRegion, string breed)
    : base(animalType, animalName, animalWeight, livingRegion)
    {
        Breed = breed;
    }

    public override void MakeSound()
    {
        Console.WriteLine("Meowww");
    }
}

