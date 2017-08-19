

namespace ReflectionTutorial
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using ReflectionTutorial.Cars;

    public class StartUp
    {
        private static int a = 5, b = 10, c = 20;

        public static void Main(string[] args)
        {
            //Console.WriteLine("a + b + c = " + (a + b + c));
            //Console.WriteLine("Please enter the name of the variable that you wish to change:");
            //string varName = Console.ReadLine();
            //Type t = typeof(StartUp);
            //FieldInfo fieldInfo = t.GetField(varName, BindingFlags.NonPublic | BindingFlags.Static);
            //if (fieldInfo != null)
            //{
            //    Console.WriteLine("The current value of " + fieldInfo.Brand + " is " + fieldInfo.GetValue(null) + ". You may enter a new value now:");
            //    string newValue = Console.ReadLine();
            //    int newInt;
            //    if (int.TryParse(newValue, out newInt))
            //    {
            //        fieldInfo.SetValue(null, newInt);
            //        Console.WriteLine("a + b + c = " + (a + b + c));
            //    }
            //    Console.ReadKey();
            //}


            //string test = "test";
            //Console.WriteLine(test.GetType().FullName); //System.String
            //Console.WriteLine(typeof(Int32).FullName); //System.Int32
            //Type t = Type.GetType("ReflectionTutorial.Mercedes"); //do not forget NAMESPACE before class! the same!
            //Type t2 = typeof(Mercedes); //the same!
            //Console.WriteLine(t.Brand); //same
            //Console.WriteLine(t2.Brand); //same

            //Type t3 = new Mercedes("", "", 1).GetType(); //there is no instance, but we crreate and get type at the same time!
            //Console.WriteLine(t3.Brand); //same as t and t2;

            //Assembly assembly = Assembly.GetExecutingAssembly();//gets current assembly;
            //Type[] assemblyTypes = assembly.GetTypes(); //array with declared CLASSes in the assembly;
            //foreach (Type t in assemblyTypes)
            //    Console.WriteLine(t.Brand);


            //HOW TO INSTANTATION AND GET AND EXECUTE METHOD 
            //AT RUNTIME BY CLASS NAME TROUGH CONSTRUCTOR:


            Type testType = typeof(Mercedes);
            ConstructorInfo ctor = testType.GetConstructor(System.Type.EmptyTypes); //for empty ctor
            ConstructorInfo ctorWithParams
                = testType.GetConstructor(new Type[] {typeof(string), typeof(string), typeof(int)}); //for empty ctor



            //How to get argsType and argsName from a ctor ??
            ParameterInfo[] paramTypeOfCtor = ctorWithParams.GetParameters();
            foreach (var param in paramTypeOfCtor)
            {
                Console.WriteLine(param.Name); //brand, model, year of production;
                Console.WriteLine(param.ParameterType.Name);//String, String, int32;
            }
            


            if (ctor != null)
            {
                object instanceWithParams = (Mercedes) ctorWithParams.Invoke(new object[] {"ss", "ss", 2016}); //call 
                //a ctor with args!

                object instance = (Mercedes)ctor.Invoke(null); //one empty instance of a class,
                //don't forget ot cast!!!

                MethodInfo methodInfo = testType.GetMethod("Drive"); //here returns the method

                MethodInfo methodInfo2 = testType.GetMethod("GiveMeTheYear"); //here returns the method

                Console.WriteLine(methodInfo.Invoke(instance, new object[] { 10 }));
                //new object[] { 10 } - array with params
                //Brummm, brummm with a 10 nummm...

                Console.WriteLine(methodInfo2.Invoke(instanceWithParams, null)); // 2016, this is null, because 
                //we already have a car, and the method is not take any args;

                var activatedMerc = (Mercedes) Activator.CreateInstance(typeof(Mercedes));
                //Created 'clean' Merc

                var activatedMercWithParams = (Mercedes) Activator.CreateInstance(typeof(Mercedes), new object[] {"Merc", "SLK", 2010});
                //Created Merc with params;


            }
        }
    }
}
