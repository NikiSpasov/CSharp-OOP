using System;
using System.Linq;
using System.Reflection;

public class SoldierFactory
{
    public ISoldier CreateSoldier(string type, string name, int age, double experiance, double endurance)
    {
        Assembly currentAssembly = Assembly.GetExecutingAssembly();
        Type currentType = currentAssembly.GetTypes().SingleOrDefault(x => x.Name == type);
        if (currentType != null)
        {
            object[] attributes = { name, age, experiance, endurance };
            return (ISoldier)Activator.CreateInstance(currentType, attributes);
        }
        return null; ;
    }
}
