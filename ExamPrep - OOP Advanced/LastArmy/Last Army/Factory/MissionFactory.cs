using System;
using System.Linq;
using System.Reflection;

public class MissionFactory
{
    public IMission CreateMission(string type, double scoreToComplete)
    {
        Assembly currentAssembly = Assembly.GetExecutingAssembly();
        Type currentType = currentAssembly.GetTypes().SingleOrDefault(x => x.Name == type);
        if (currentType != null)
        {
            object[] attributes = { scoreToComplete };
            return (IMission)Activator.CreateInstance(currentType, attributes);
        }
        return null;
    }
}

