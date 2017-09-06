public class NightVision : Ammunition
{
    public const double constWeight = 0.8;

    public NightVision(string name)
        : base(name)
    {
        this.Weight = constWeight;

    }
}
