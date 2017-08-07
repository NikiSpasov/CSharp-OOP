using System.Linq;
using System.Reflection;

namespace _02BlackBoxInteger
{
    using System;

    public class BlackBoxIntegerTests
    {
        public static void Main()
        {
            Type blackBoxType = typeof(BlackBoxInt);

            //DIRECT VARIANT A:
            BlackBoxInt myBlackBox = (BlackBoxInt)Activator
                .CreateInstance(blackBoxType, true);
            //here "true" is for NON Public ctor and create direct istance!

            //Variant B with ctor:
            //ConstructorInfo blackBoxCtor = blackBoxType.GetConstructor
            //    (BindingFlags.Instance | BindingFlags.NonPublic, Type.DefaultBinder, 
            //    new Type[]{}, null);
            //var istance = (BlackBoxInt)blackBoxCtor.Invoke(new object[0]);
            //istance = blackBox
            string inputLine;
            while ((inputLine = Console.ReadLine()) != "END")
            {
                string[] tokens = inputLine.Split('_');
                string methodName = tokens[0];
                int value = int.Parse(tokens[1]);

                blackBoxType.GetMethod(methodName, BindingFlags.Instance | BindingFlags.NonPublic)
                    .Invoke(myBlackBox, new object[] {value});

                string innerStateValue = blackBoxType.GetFields(BindingFlags.Instance |
                    BindingFlags.NonPublic)
                    .First()
                    .GetValue(myBlackBox)
                    .ToString();

                Console.WriteLine(innerStateValue);
            }


        }
    }
}
