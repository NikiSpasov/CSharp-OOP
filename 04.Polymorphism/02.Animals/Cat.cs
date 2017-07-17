
using System;

class Cat : Animal
{
    public override string ExplainMyself()
    {
        return $"{base.ExplainMyself()}{Environment.NewLine}MEEOW";
    }

    public Cat(string name, string favouriteFood)
    {
        base.Name = name;
        base.FavouriteFood = favouriteFood;
    }
}

