
public class MachineGun : Ammunition
{
    public const double constWeight = 10.6;

    public MachineGun(string name)
        : base(name)
    {
        this.Weight = constWeight;

    }
}
