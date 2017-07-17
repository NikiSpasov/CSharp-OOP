using System;
public class Zebra : Mammal
{
    public const string Type = "Zebra";


    public Zebra(string animalName, double animalWieght, string region)
        : base(Type, animalName, animalWieght, region)
    {
    }

    public override void MakeNoise()
    {
        Console.WriteLine("Zs");
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