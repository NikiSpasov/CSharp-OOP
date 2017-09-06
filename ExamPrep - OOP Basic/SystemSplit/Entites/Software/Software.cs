public abstract class Software
{
    private string type;
    private string name;
    private int capacityCosnsumption;
    private int memoryConsumption;

    public Software(string type, string name, int capacityCosnsumption, int memoryConsumption)
    {
        this.Type = type;
        this.Name = name;
        this.CapacityCosnsumption = capacityCosnsumption;
        this.MemoryConsumption = memoryConsumption;
    }

    public string Name
    {
        get => this.name;
        protected set => this.name = value;
    }

    public int CapacityCosnsumption
    {
        get => this.capacityCosnsumption;
        protected set => this.capacityCosnsumption = value;
    }

    public int MemoryConsumption
    {
        get => this.memoryConsumption;
        protected set => this.memoryConsumption = value;
    }

    public string Type
    {
        get => this.type;
        set => this.type = value;
    }
}

