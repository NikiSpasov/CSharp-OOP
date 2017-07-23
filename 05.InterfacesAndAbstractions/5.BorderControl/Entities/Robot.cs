using System;

public class Robot : ICreature
{
    private string id;
    private string model;

    public Robot(string type, string model, string id)
    {
        Id = id;
        Model = model;
        Type = type;
    }

    public string Id
    {
        get => id;
        private set { this.id = value; }
    }

    public string Type { get; }

    public string Model
    {
        get => this.model;
        private set { this.model = value; }
    }
}

