using System.Collections.Generic;
using System.Linq;
using System.Threading;

public abstract class Soldier : ISoldier
{
    
    private string name;
    private int age;
    private double experience;
    private double endurance;
    private double overallSkill;
    private IDictionary<string, IAmmunition> weapons;

    protected Soldier(string name, int age, double experience, double endurance)
    {
        this.Name = name;
        this.Age = age;
        this.Experience = experience;
        this.Endurance = endurance;
        this.Weapons = new Dictionary<string, IAmmunition>();
    }

    public IReadOnlyList<string> WeaponsAllowed { get; protected set; }

    public abstract void Regenerate(); 

    public bool ReadyForMission(IMission mission)
    {
        if (this.Endurance < mission.EnduranceRequired)
        {
            return false;
        }

        bool hasAllEquipment = this.Weapons.Values.Count(weapon => weapon == null) == 0;

        if (!hasAllEquipment)
        {
            return false;
        }

        return this.Weapons.Values.Count(weapon => weapon.WearLevel <= 0) == 0;
    }

    public void CompleteMission(IMission mission)
    {
        this.Endurance -= mission.EnduranceRequired;
        foreach (var weapon in this.Weapons.Values)
        {
            weapon.DecreaseWearLevel(mission.WearLevelDecrecement);
        }
        this.Experience += mission.EnduranceRequired;
    }

    public override string ToString() => $"{this.Name} - {this.OverallSkill}";

    public double Endurance
    {
        get => this.endurance;
        protected set => this.endurance = value;
    }

    public string Name
    {
        get => this.name;
        set => this.name = value;
    }

    public int Age
    {
        get => this.age;
        set => this.age = value;
    }

    public double Experience
    {
        get => this.experience;
        set => this.experience = value;
    }

    public double OverallSkill
    {
        get => this.Age + this.Experience;
        protected set => this.overallSkill = value; //WatchOut!
    }

    public IDictionary<string, IAmmunition> Weapons
    {
        get => this.weapons;
        set => this.weapons = value;
    }
}