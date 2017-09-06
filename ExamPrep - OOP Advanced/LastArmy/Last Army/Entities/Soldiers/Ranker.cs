using System.Collections.Generic;

public class Ranker : Soldier
    {
        private const double OverallSkillMultiplier = 1.5;
        private const int RegenerationIndex = 10;

        private readonly List<string> weaponsAllowed = new List<string>
        {
            "Gun",
            "AutomaticMachine",
            "Helmet"
        };

        public Ranker(string name, int age, double experience, double endurance)
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

