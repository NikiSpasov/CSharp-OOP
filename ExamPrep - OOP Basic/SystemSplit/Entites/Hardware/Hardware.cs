using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

public abstract class Hardware
{
    private string name;
    private int maxCapacity;
    private int maxMemory;
    private string type;
    private Dictionary<string, Software> softwareList;

    public Hardware(string type, string name, int maxCapacity, int maxMemory)
    {
        this.Name = name;
        this.MaxCapacity = maxCapacity;
        this.MaxMemory = maxMemory;
        this.Type = type;
        this.SoftwareDict = new Dictionary<string, Software>();
    }

    public void RegisterSoftware(Software soft)
    {
        int sumOfTakenMemory = this.softwareList.Values.Sum(x => x.MemoryConsumption);
        int sumOfTakenCapacity = this.softwareList.Values.Sum(x => x.CapacityCosnsumption);
        if (this.MaxCapacity < soft.CapacityCosnsumption + sumOfTakenCapacity ||
            this.MaxMemory < soft.MemoryConsumption + sumOfTakenMemory)
        {
            return;
        }

        this.SoftwareDict.Add(soft.Name, soft);
    }

    public string Name
    {
        get => this.name;
        protected set => this.name = value;
    }

    public string Type
    {
        get => this.type;
        protected set => this.type = value;
    }

    public int MaxCapacity
    {
        get => this.maxCapacity;
        protected set => this.maxCapacity = value;
    }
    public int MaxMemory
    {
        get => this.maxMemory;
        protected set => maxMemory = value;
    }

    public Dictionary<string, Software> SoftwareDict
    {
        get => this.softwareList;
        protected set => softwareList = value;
    }
}

