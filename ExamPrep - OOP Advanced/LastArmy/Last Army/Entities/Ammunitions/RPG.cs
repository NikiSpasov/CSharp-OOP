public class RPG : Ammunition
{
    public const double constWeight = 17.1;

    public RPG(string name)
        : base(name)
    {
        this.Weight = constWeight;
    }
}
