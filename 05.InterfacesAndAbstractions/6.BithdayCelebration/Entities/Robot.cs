using System;

public class Robot : IPeople
{
    private string id;
    private string model;

    public Robot(string model, string id)
    {
        Id = id;
        Model = model;
    }

    public string Id
    {
        get => id;
        private set { this.id = value; }
    }

    public string Model
    {
        get => this.model;
        private set { this.model = value; }
    }
}

