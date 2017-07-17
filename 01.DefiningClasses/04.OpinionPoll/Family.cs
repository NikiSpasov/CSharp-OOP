
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

public class Family
{
    public static List<Person> FamiliMembers = new List<Person>();
    public static void AddMember(Person member)
    {
        FamiliMembers.Add(member);
    }

    public static Person GetOldestMember(List<Person> familiMember)
    {
        Person theOldest = familiMember
            .OrderBy(x => x.age)
            .Last();
        return theOldest;
    }   
}

