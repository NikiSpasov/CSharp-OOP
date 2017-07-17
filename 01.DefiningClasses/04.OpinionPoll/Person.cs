
    using System.Collections.Specialized;
    using System.Security.Cryptography.X509Certificates;

public class Person
{
    public string name;
    public int age;
    public Person()
    { 
    }

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
}