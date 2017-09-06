public class PowerHardware : Hardware
{
    private const string TypePower = "Power"; 

    public PowerHardware(string name, int maxCapacity, int maxMemory) 
        : base(TypePower, name, maxCapacity, maxMemory)
    {
        this.MaxCapacity -= this.MaxCapacity * 75 / 100;
        this.MaxMemory += this.MaxMemory * 75 / 100;
    }
}

