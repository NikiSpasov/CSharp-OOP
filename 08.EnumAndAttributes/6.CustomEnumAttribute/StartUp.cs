using System;

public class Startup
{
    public static void Main()
    {
        var input = Console.ReadLine();
        //IEnumerable<Attribute> result = null;
        object[] result = null;
        switch (input)
        {
            case "Rank":
                result = typeof(Rank).GetCustomAttributes(true);
                break;
            case "Suit":
                result = typeof(Suit).GetCustomAttributes(true);
                break;
        }
        foreach (var attr in result)
        {
            var typeAttr = attr as TypeAttribute;
            Console.WriteLine($"Type = {typeAttr.Type}, Description = {typeAttr.Description}");
        }

    }
}