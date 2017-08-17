
using System;
using Microsoft.Win32;

public class Person : IComparable<Person>
{
    private string name;
    private int age;
    private string town;


    public Person(string name, int age, string town)
    {
        this.Name = name;
        this.Age = age;
        this.Town = town;
    }

    public string Town
    {
        get { return this.town; }
        private set { this.town = value; }
    }


    public int Age
    {
        get { return this.age; }
        private set { this.age = value; }
    }


    public string Name
    {
        get { return this.name; }
        private set { this.name = value; }
    }

    public int CompareTo(Person other)
    {
        var nameCompare = this.Name.CompareTo(other.Name);
        var ageCompare = this.Age.CompareTo(other.Age);
        var townCompare = this.Town.CompareTo(other.Town);

        if (nameCompare != 0)
        {   
            return nameCompare;
        }
        if (ageCompare != 0)
        {
            return ageCompare;
        }
        if (townCompare != 0)
        {
            return townCompare;
        }
        return 0;
    }
}

