using System;
using System.Collections;
using System.Collections.Generic;

public class Pet : IEnumerable<Pet>
{
    private string name;
    private int age;
    private string kind;
    public static List<Pet> PetList = new List<Pet>();

    public Pet(string name, int age, string kind)
    {
        this.name = name;
        this.age = age;
        this.kind = kind;
    }

    public static void CreatePet(List<string> cmdArgs)
    {
        Pet currentPet = new Pet(cmdArgs[0], int.Parse(cmdArgs[1]), cmdArgs[2]);
        PetList.Add(currentPet);
    }

    public string Kind
    {
        get { return this.kind; }
        set { this.kind = value; }
    }

    public int Age
    {
        get { return this.age; }
        set { this.age = value; }
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public IEnumerator<Pet> GetEnumerator()
    {
        for (int i = 0; i < PetList.Count; i++)
        {
            yield return PetList[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

