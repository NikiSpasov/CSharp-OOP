
using System.Collections.Generic;
using System.Linq;

public class WareHouse : IWareHouse
{
    public WareHouse()
    {
        this.Ammunitions = new Dictionary<IAmmunition, int>();
    }

    public void EquipArmy(IArmy army)
    {
        foreach (var soldier in army.Soldiers)
        {
            foreach (var weapon in this.Ammunitions)
            {
                if (soldier.WeaponsAllowed.Contains(weapon.Key.Name) && weapon.Value > 0)
                {
                    if (!soldier.Weapons.ContainsKey(weapon.Key.Name))
                    {
                        soldier.Weapons.Add(weapon.Key.Name, weapon.Key);
                    }
                }
            }
            foreach (var weaponInSoldier in soldier.Weapons)
            {
                Ammunitions[weaponInSoldier.Value]--;
            }
        }
    }

    public Dictionary<IAmmunition, int> Ammunitions { get; }

    public void AddAmmunition (IAmmunition ammuniton, int count)
    {
        if (!this.Ammunitions.ContainsKey(ammuniton))
        {
            this.Ammunitions.Add(ammuniton, count);
            return;
        }
        this.Ammunitions[ammuniton] += count;
    }
}

