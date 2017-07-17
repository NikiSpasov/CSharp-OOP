public class HammerHarvester : Harvester
{
    public string type;
    public HammerHarvester(string type, string id, double oreOutput, double energyRequirement) 
        : base(id, oreOutput, energyRequirement)
    {
        OreOutput = OreOutput + OreOutput * 2;
        EnergyRequirement = EnergyRequirement * 2;
        this.type = type;
    }
}

