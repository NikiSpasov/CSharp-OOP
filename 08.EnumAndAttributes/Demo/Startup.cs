
using System;
using System.Threading;

[Serializable]
public class Startup
{
    [Author("Pesho")] //when the atrr class has property Name, we can
    //oprionaly put it! It' s OPTIONAL
    //but
    //if we have it in a constructor, than we OBLIGATORY has to pass the data and than, if
    //we want, we can add propeties


    public static void Main()
    {
        //Parse from int: // Produce exception if enum doesn't consist value

        int n = 1;


        Color testColor = (Color)Enum.Parse(typeof(Color), n.ToString());
        Console.WriteLine(testColor); //"Blue"

        //Safe variant:

        Color color;
        Enum.TryParse(n.ToString(), out color);
        Console.WriteLine(color); //Blue

        Enum.TryParse("9", out color);
        Console.WriteLine(color);//9, there is no match from int representation from Enum!
        //ATTENTION - if the string is int.parsable , ok, but:

        if (Enum.TryParse("Dog", out color))//null, but run-time it's Red??

        {
            Console.WriteLine(color);

        }





        //var attributes = typeof(Startup).GetCustomAttributes(false);

        //foreach (var attr  in attributes)
        //{
        //    Console.WriteLine(attr.ToString());//System.SerializableAttribute
        //}

        //foreach (var attr in attributes)
        //{
        //    if (attr is SerializableAttribute)
        //    {
        //        Console.WriteLine("True, it's Serializeable");
        //    }   
        //}

        //var color = Color.Blue;  //from enum Color
        //Console.WriteLine(color);//Blue
        //var intColor = (int)Color.Blue; 
        //Console.WriteLine(intColor);//1
        //var otherColor = (Color) 1;
        //Console.WriteLine(otherColor);//Blue

        //var values = Enum.GetValues(typeof(Color));//array with all enum values

        //foreach (var value in values)
        //{
        //    Console.WriteLine(value);


        //Cat cat = new Cat();
        // cat.Name = "Ivan";

        // ChangeName(cat);
        // Console.WriteLine(cat.Name); // "ChangedCat"

        // var dog = new Dog();
        // dog.Name = "Gosho";
        // ChangeNameDog(dog);
        // Console.WriteLine(dog.Name); //ATTENTION - "Gosho"

        //public static void ChangeName(Cat cat)
        //{
        //    cat.Name = "ChangedCat";
        //}

        //public static void ChangeNameDog(Dog dog)
        //{
        //    dog.Name = "ChangedDog";
        //}

        //var parsedValue = Enum.Parse(typeof(Color), "blue", true); //parse ot Color.Blue

        //Color toGetFromTryParse; //Blue;
        //Enum.TryParse("Blue", out toGetFromTryParse);


        //ATTRIBUTES

        //with [] above class
        // An attribute doesn't change program behaiviour;


    }



}


