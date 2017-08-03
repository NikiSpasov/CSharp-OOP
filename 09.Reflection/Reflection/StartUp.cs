using System;
using System.CodeDom;
using System.Reflection;

namespace Reflection
{
    public class StartUp

    {
        public static void Main()
        {
            //with Reflection, one program can analyze it's own data types

            //Class Type:

            //First - for existing instance:

            //var obj = new object();
            //Type typeOfObj = obj.GetType();

            ////Second /there is no existing instance of a class: 

            //Type startupType = typeof(StartUp);

            ////For Cat class:
            //Type typeOfCat = new Cat().GetType();
            //Type typeOfCatWithoutInstance = typeof(Cat);

            //var type = typeof(Cat);
            

            //What can we do:

            //Console.WriteLine(typeOfCat.Name);//Cat - the name of the class
            //Console.WriteLine(typeOfCat.FullName);//Reflection.Cat - namespace + class

            //foreach (var prop in typeOfCat.GetProperties()) //here it returns collection of properties from "Cat" class
            //{
            //    Console.WriteLine(prop.Name + " " + prop.PropertyType.Name);//Name String, Age int32
            //}

            //Console.WriteLine(type.BaseType.FullName);//Reflection.Animal
            //var typeOfAnimal = type.BaseType;

            //var allInterfaces = typeOfAnimal.GetInterfaces();

            //foreach (var interf in allInterfaces)
            //{
            //    Console.WriteLine(interf.Name);
            //}
            //IBreathable
            //IMoveabale


            //var typesInCurrentAssembly = Assembly.GetEntryAssembly()
            //    .GetTypes();

            //foreach (var tpe in typesInCurrentAssembly)
            //{
            //    Console.WriteLine(tpe.Name);
            //}

            //var cat = (Cat)Activator.CreateInstance(typeof(Cat));//if the constructor is empty
            ////this is the same like:
            //var anotherCat = new Cat();
            ////but if the constructor is not empty:
            //var catWithParams = (Cat) Activator.CreateInstance(typeof(Cat), "Pesho");//if the ctor is with one string Name.
            ////otherwise - exeption;

            var typeOfCat = typeof(Cat);

            var cat = new Cat();
            var fields = typeOfCat.GetFields(
                BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);//all fields,
            //modified by BindingFlags;
            //var field = typeOfCat.GetField("Name"); //this field, IF IT EXIST!
            foreach (var field in fields)
            {
                Console.WriteLine(field.Name);
                if (field.Name.Contains("Name"))
                {
                    field.SetValue(cat, "Pesho");//to an instance
                }
            }
            Console.WriteLine(cat.Name);//Pesho

            var properties = typeOfCat.GetProperties();
            foreach (var prop in properties)
            {
                Console.WriteLine(prop.Name); //Name, Age
            }

            var constructors = typeof(Cat).GetConstructors();
            foreach (var constructor in constructors)
            {
                var parametars = constructor.GetParameters();
                foreach (var param in parametars)
                {
                    Console.WriteLine(param.Name);
                }
            }
            var construct = typeof(Cat).GetConstructor(Type.EmptyTypes);
            var caty = construct.Invoke(new object[0]);
            var name = typeof(Cat)
                .GetProperty("Name")
                .GetCustomAttribute<AuthorAttribute>()
                ?.Name;

        }
    }

}


