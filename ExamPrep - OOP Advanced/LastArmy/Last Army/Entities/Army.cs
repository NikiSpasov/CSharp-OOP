using System.Collections.Generic;
using System.Linq;

public class Army : IArmy
{
    private IList<ISoldier> soldiers = new List<ISoldier>();

    public Army()
    {
        this.soldiers = new List<ISoldier>();
    }

    public IReadOnlyList<ISoldier> Soldiers
    {
        get => (IReadOnlyList<ISoldier>)this.soldiers;
    }

    public void AddSoldier(ISoldier soldier)
    {
        this.soldiers.Add(soldier);
    }

    public void RegenerateTeam(string soldierType)
    {
        foreach (var soldier in this.Soldiers.Where(x => x.GetType().Name == soldierType)) //check it!
        {
            soldier.Regenerate();
        }
    }
}