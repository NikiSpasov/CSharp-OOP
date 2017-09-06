public class Gun : Ammunition
{
    public const double constWeight = 1.4;

    public Gun(string name)
        : base(name)
    {
        this.Weight = constWeight;
    }
}
