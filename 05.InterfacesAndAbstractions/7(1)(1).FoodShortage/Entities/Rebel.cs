public class Rebel : IBuyer
{
    public string Name { get; }
    public string Group { get; }
    public int Age { get; }
    public int Food { get; private set; }


    public Rebel(string name, int age, string group)
    {
        Name = name;
        Group = group;
        Age = age;
    }

    public void BuyFood()
    {
        Food += 5;
    }
}

