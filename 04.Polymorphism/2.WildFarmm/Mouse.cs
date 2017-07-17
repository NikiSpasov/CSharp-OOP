using System;

public class Mouse : Mammal
{
    public const string Type = "Mouse";

    public Mouse(string animalName, double animalWieght, string region)
        : base(Type, animalName, animalWieght, region)
    {
    }

    public override void MakeNoise()
    {
        Console.WriteLine("SQUEEEAAAK!");
    }

    public override void EatFood(Food f)
    {
        if (f.Type != "Vegetable")
        {
            AnimalCannotEat();
        }
        else
        {
            base.EatFood(f);
        }
    }
}
