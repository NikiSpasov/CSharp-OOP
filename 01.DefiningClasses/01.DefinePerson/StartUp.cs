

using System;
using System.Reflection;

class StartUp
{
    static void Main()
    {
        Type personType = typeof(Person);
        FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);
        Console.WriteLine(fields.Length);

        Person pesho = new Person
        {
            name = "Pesho",
            age = 20
        };
        Person gosho = new Person("Gosho", 26);

    }
}
