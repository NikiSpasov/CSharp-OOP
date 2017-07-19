public class Citizen : IPerson, IBirthable, IIdentifiable
{
    private string name;
    private int age;
    private string id;
    private string birthdate;

    public Citizen(string name, int age, string id, string birthdate)
    {
        Name = name;
        Age = age;
        Id = id;
        Birthdate = birthdate;

    }

    public string Name
    {
        get { return this.name; }
        private set { this.name = value; }
    }
    public int Age
    {
        get { return this.age; }
        private set { this.age = value; }
    }

    public string Birthdate
    {
        get { return this.birthdate; }
        private set { this.birthdate = value; }
    }

    public string Id
    {
        get { return this.id; }
        set { this.id = value; }
    }
}

