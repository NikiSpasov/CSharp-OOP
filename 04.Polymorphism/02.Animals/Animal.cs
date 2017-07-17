
public class Animal
{
    protected string name;
    protected string favouriteFood;

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public string FavouriteFood
    {
        get { return this.favouriteFood; }
        set { this.favouriteFood = value; }
    }

    public virtual string ExplainMyself()
    {
        return $"I am {Name} and my favourite food is {FavouriteFood}";
    }

}

