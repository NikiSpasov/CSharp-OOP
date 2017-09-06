using System.Collections.Generic;

class Corporal : Soldier
{
    private const double OverallSkillMultiplier = 2.5;
    private const int RegenerationIndex = 10;

    private readonly List<string> weaponsAllowed = new List<string>
    {
        "Gun",
        "AutomaticMachine",
        "MachineGun",
        "Helmet",
        "Knife"        
    };

    public Corporal(string name, int age, double experience, double endurance)
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

