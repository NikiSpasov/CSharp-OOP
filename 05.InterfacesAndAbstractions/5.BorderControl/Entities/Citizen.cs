
using System.Collections.Generic;

public class Citizen : IBreathable
{
    private string id;
    private string name;
    private int age;
    private string birthdate;


    public Citizen(string type, string name, int age, string id, string birthdate)
    {
        Type = type;
        Name = name;
        Age = age;
        Id = id;
        Birthdate = birthdate;
    }

    public string Birthdate
    {
        get { return this.birthdate; }
        set { this.birthdate = value; }
    }
    

    public string Id
    {
        get => this.id;
        private set { this.id = value; }
    }

    public string Type { get; }

    public string Name
    {
        get => this.name;
        private set { this.name = value; }
    }

    public int Age
    {
        get => this.age;
        private set => this.age = value;
    }

}


