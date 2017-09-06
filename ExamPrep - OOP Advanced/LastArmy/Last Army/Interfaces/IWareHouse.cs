using System.Collections.Generic;

public interface IWareHouse
{    
    void EquipArmy(IArmy army); // ???

    Dictionary<IAmmunition, int> Ammunitions { get; }

    void AddAmmunition(IAmmunition ammuniton, int count);
}
