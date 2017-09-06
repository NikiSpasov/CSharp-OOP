using System;
using System.Linq;
using System.Reflection;
public class AmmunitionFactory
{

    public IAmmunition CreateAmmunition(string type)
    {
        {
            Assembly currentAssembly = Assembly.GetExecutingAssembly();
            Type currentType = currentAssembly.GetTypes().SingleOrDefault(x => x.Name == type);
            if (currentType != null)
            {
                object[] attributes = { type };
                return(IAmmunition)Activator.CreateInstance(currentType, attributes);
            }
            return null;
        }
    }
}
