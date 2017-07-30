
using System;

public class Startup
{
    public static void Main()
    {
        var color = Color.Blue;  //from enum Color
        Console.WriteLine(color);















       //Cat cat = new Cat();
       // cat.Name = "Ivan";

       // ChangeName(cat);
       // Console.WriteLine(cat.Name); // "ChangedCat"

       // var dog = new Dog();
       // dog.Name = "Gosho";
       // ChangeNameDog(dog);
       // Console.WriteLine(dog.Name); //ATTENTION - "Gosho"
    }

    public static void ChangeName(Cat cat)
    {
        cat.Name = "ChangedCat";
    }

    public static void ChangeNameDog(Dog dog)
    {
        dog.Name = "ChangedDog";
    }
}
