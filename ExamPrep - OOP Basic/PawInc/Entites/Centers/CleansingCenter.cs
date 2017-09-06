using System.Collections.Generic;

public class CleansingCenter : Center
{
    private List<Animal> cleansedAnimals;
    private Dictionary<string, List<Animal>> sendersAndAnimals;

    public CleansingCenter(string name) : base(name)
    {
        this.SendersAndAnimals = new Dictionary<string, List<Animal>>();
        this.CleansedAnimals = new List<Animal>();
    }

    public Dictionary<string, List<Animal>> SendersAndAnimals
    {
        get => this.sendersAndAnimals;
        set => this.sendersAndAnimals = value;
    }

    public List<Animal> CleansedAnimals
    {
        get => this.cleansedAnimals;
        private set => this.cleansedAnimals = value;
    }

    public void Cleanse()
    {
        foreach (var senderAndAnimal in this.sendersAndAnimals)
        {
            
        }
    }
}