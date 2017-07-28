
using System;
using System.Collections.Generic;

public class Person
{
    private string name;
    private int age;

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
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

   public class NameLenght : IComparer<Person>
   {
       public int Compare(Person x, Person y)
       {
           int result = x.Name.Length.
                        CompareTo(y.Name.Length);
           if(result == 0)
           {
               string first = x.Name.ToLower();
               string second = y.Name.ToLower();
               result = first[0].CompareTo(second[0]);
           }
           return result;
       }
   }

    public class Years : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.Age.CompareTo(y.Age);
        }
    }
}

