using System.Collections.Generic;

public abstract class Center
{
    private string name;
    private List<Animal> animals;

    protected Center(string name)
    {
        this.Name = name;
        this.Animals = new List<Animal>();
    }

    public string Name
    {
        get => this.name;
        private set => this.name = value;
    }

    public List<Animal> Animals
    {
        get => this.animals;
        set => this.animals = value;
    }
}

