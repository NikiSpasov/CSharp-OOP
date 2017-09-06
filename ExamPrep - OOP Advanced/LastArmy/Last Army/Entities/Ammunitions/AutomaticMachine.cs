public class AutomaticMachine : Ammunition
{
    public const double constWeight = 6.3;

    public AutomaticMachine(string name)
        : base(name)
    {
        this.Weight = constWeight;
    }
}