
using System;

public class Dog : Animal
{
    public override string ExplainMyself()
    {
        return $"{base.ExplainMyself()}{Environment.NewLine}DJAAF";
    }

    public Dog(string name, string favoutiteFood)
    {
        base.Name = name;
        base.FavouriteFood = favoutiteFood;
    }
}

