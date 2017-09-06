public abstract class Ammunition : IAmmunition
{
    private string name;
    private double weight;
    private double wearLevel;

    public Ammunition(string name)
    {
        this.Name = name;
        this.WearLevel = this.Weight * 100;
    }

    public void DecreaseWearLevel(double wearAmount)
    {
        this.WearLevel -= wearAmount;
    }

    public string Name
    {
        get => this.name;
        protected set => this.name = value;
    }

    public double Weight
    {
        get => this.weight;
        protected set => this.weight = value;
    }

    public double WearLevel
    {
        get => this.wearLevel;
        protected set => this.wearLevel = value;
    }
}
