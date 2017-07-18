
using System;

public abstract class Harvester
{
    private string id;
    private double oreOutput;
    private double energyRequirement;

    protected Harvester(string id, double oreOutput, double energyRequirement)
    {
        Id = id;
        OreOutput = oreOutput;
        EnergyRequirement = energyRequirement;
    }

    public string Id
    {
        get { return this.id; }
        set { this.id = value; }
    }

    public double OreOutput
    {
        get { return this.oreOutput; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException(
                $"Harvester is not registered, because of it's {nameof(OreOutput)}");
                
            }
            this.oreOutput = value;

        }
    }

    public double EnergyRequirement
    {
        get { return this.energyRequirement; }
        set
        {
            if (value < 0 || value > 20000)
            {
                throw new ArgumentException(
                $"Harvester is not registered, because of it's {nameof(EnergyRequirement)}");
                
            }
            this.energyRequirement = value;
        }

    }
}


