public class LightSoftware : Software
{
    private const string LightType = "Light";

    public LightSoftware(string name, int capacityCosnsumption, int memoryConsumption) 
        : base(LightType, name, capacityCosnsumption, memoryConsumption)
    {
        this.CapacityCosnsumption += this.CapacityCosnsumption * 50 / 100;
        this.MemoryConsumption -= this.MemoryConsumption * 50 / 100;
    }
}
