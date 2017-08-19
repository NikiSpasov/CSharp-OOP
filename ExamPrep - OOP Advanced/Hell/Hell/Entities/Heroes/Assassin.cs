public class Assassin : AbstractHero
{
    public Assassin(string name)
        : base(name, AssassinStrength, AssassinAgility, AssassinIntelligence,
            AssassinHitPoints, AssassinDamage)
    {

    }

    private const int AssassinStrength = 25;
    private const int AssassinAgility = 100;
    private const int AssassinIntelligence = 15;
    private const int AssassinHitPoints = 150;
    private const int AssassinDamage = 300;
}