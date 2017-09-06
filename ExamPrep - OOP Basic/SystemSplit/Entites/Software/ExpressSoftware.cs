public class ExpressSoftware : Software
{
    private const string ExpressSoft = "Express";
        public ExpressSoftware(string name, int capacityCosnsumption, int memoryConsumption) 
        : base(ExpressSoft, name, capacityCosnsumption, memoryConsumption)
        {
            this.MemoryConsumption += this.MemoryConsumption;
        }
    }

