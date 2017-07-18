using System;

public abstract class Provider
{
    private string id;
    private double energyOutput;
    private bool error;

    protected Provider(string id, double energyOutput)
    {
        Id = id;
        EnergyOutput = energyOutput;
    }


    public double EnergyOutput
    {
        get { return this.energyOutput; }
        set
        {
               error = false; 
                
               if (value < 1 || value > 9999)
                {
                    throw new ArgumentException(
                    $"Provider is not registered, because of it's {nameof(EnergyOutput)}");
                }
            if (!error)
            {
                this.energyOutput = value;

            }

        }
    }

    public string Id
    {
        get { return this.id; }
        set { this.id = value; }
    }

}

