
public class Helmet : Ammunition
{
    public const double constWeight = 2.3;

    public Helmet(string name)
        : base(name)
    {
        this.Weight = constWeight;

    }
}
