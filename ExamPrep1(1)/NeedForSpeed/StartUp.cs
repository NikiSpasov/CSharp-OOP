
using System;
using System.Collections.Generic;
using System.Security.Cryptography;

public class StartUp
{
    public static void Main()
    {
        string input = Console.ReadLine();
        CarManager carManager = new CarManager();

        while (input != "Cops are here")
        {
            carManager.Commands(input);

            input = Console.ReadLine();
        }
    }
}

