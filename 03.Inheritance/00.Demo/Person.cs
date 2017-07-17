
using System;

public class Person
{
    private string name;
    private int age;
    protected int height;

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

    public Person(int height)
    {
        this.height = height;
    }



}

