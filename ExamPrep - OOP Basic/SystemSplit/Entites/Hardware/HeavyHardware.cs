public class HeavyHardware : Hardware
{
    private const string HeavyPower = "Heavy";

    public HeavyHardware(string name, int maxCapacity, int maxMemory)
        : base(HeavyPower, name, maxCapacity, maxMemory)
    {
        this.MaxMemory -= this.MaxMemory * 25 / 100;
        this.MaxCapacity += this.MaxCapacity;
    }
}

