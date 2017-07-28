using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public class Person
{
    private string name;
    private int age;

    public Person(string name, int age)
    {
        this.age = age;
        this.name = name;
    }

    public string Name
    {
        get => this.name;
        set => this.name = value;
    }

    public int Age
    {
        get => this.age;
        set => this.age = value;
    }
    public class GetThisHash : IEqualityComparer<Person>
    {
        public bool Equals(Person x, Person y)
        {
            bool result = false;
            if (x.age == y.age && x.name == y.name)
            {
                return true;
            }
            return result;
        }

        public int GetHashCode(Person obj)
        {
            return obj.Name.GetHashCode() * 17 + obj.Age.GetHashCode();
        }
    }
    public class ComprarePerson : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            int result = 0;
            if (x.Name == y.Name && x.Age == y.Age)
            {
                return result;
            }
            if (x.Name.CompareTo(y.Name) != 0)
            {
                return x.Name.CompareTo(y.Name);
            }
            if (x.Age.CompareTo(y.Age) != 0)
            {
                return x.Age.CompareTo(y.Age);
            }
            return result;
        }
    }
}

