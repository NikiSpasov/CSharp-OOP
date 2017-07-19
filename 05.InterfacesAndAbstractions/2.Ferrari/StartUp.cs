using System;

public class StartUp
{
    public static void Main()
    {
        string name = Console.ReadLine();
        ICar ferrari = new Ferrari(name);
        Console.WriteLine($"{ferrari.Model}" +
                          $"/{ferrari.UseBreaks()}" +
                          $"/{ferrari.PushGasPedal()}" +
                          $"/{ferrari.Driver}");


        //bottom:
        string ferrariName = typeof(Ferrari).Name;
        string iCarInterfaceName = typeof(ICar).Name;

        bool isCreated = typeof(ICar).IsInterface;
        if (!isCreated)
        {
            throw new Exception("No interface ICar was created");
        }

    }
}

