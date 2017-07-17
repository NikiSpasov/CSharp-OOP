using System.Net.Configuration;
using System.Runtime.CompilerServices;

public class Engine
{
    private string model;
    private int power;
    public string displacements;
    public string efficency;

    public string Model
    {
        get
        {
            return this.model;
            
        }
        set { this.model = Model; }
    }

    public string Displacement { get; set; } = "n/a";

    public string Efficency { get; set; } = "n/a";

    public int Power
    {
        get { return this.power; }
        set { this.power = Power; }
    }

    public Engine(string model, int power)
    {
        this.model = model;
        this.power = power;
    }

    public Engine(string model, int power, string displacement)
        :this(model, power)
    {
        this.displacements = displacement;
    }

    public Engine(string model, int power, string displacement, string efficency)
        :this(model, power, displacement)
    {
        this.efficency = efficency;
    }
}