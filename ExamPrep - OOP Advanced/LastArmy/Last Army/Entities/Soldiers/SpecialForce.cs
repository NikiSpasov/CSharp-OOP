using System.Collections.Generic;

public class SpecialForce : Soldier
{
    private const double OverallSkillMultiplier = 3.5;
    private const int RegenerationIndex = 30;

    private readonly List<string> weaponsAllowed = new List<string>
    {
        "Gun",
        "AutomaticMachine",
        "MachineGun",
        "RPG",
        "Helmet",
        "Knife",
        "NightVision"
    };

    public SpecialForce(string name, int age, double experience, double endurance)
        : base(name, age, experience, endurance)
    {
        this.OverallSkill *= OverallSkillMultiplier;
        this.WeaponsAllowed = this.weaponsAllowed;
    }

    public override void Regenerate()
    {
        this.Endurance += (RegenerationIndex + this.Age);
    }
}
