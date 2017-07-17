using System.Dynamic;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using Microsoft.SqlServer.Server;

public class Car
{
    private string model;
    private Engine engine;
    private string weight;
    private string color;

    public Engine Engine
    {
        get { return this.engine; }
        set { this.engine = value; }
    }

    public string Model
    {
        get { return this.model; }
        set { this.model = value; }
    }

    public string Weight { get; set; } = "n/a";

    public string Color { get; set; } = "n/a";

    public Car(string model, Engine engine)
    {
        this.model = model;
        this.engine = engine;
    }

    public Car(string model, Engine engine, string weight )
        :this(model, engine)
    {
        this.weight = weight;
    }

    public Car(string model, Engine engine, string weight, string color)
        :this(model, engine, weight)
    {
        this.color = color;
    }
}

