
using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        PrimitiveCalculator calculator = new PrimitiveCalculator();

        string input = Console.ReadLine();

        while (input != "End")
        {
            string[] args = input.Split();
            if (args[0] == "mode")
            {
                char[] strategy = args[1].ToCharArray();
                calculator.changeStrategy(strategy[0]);
                input = Console.ReadLine();
                continue;
            }
            Console.WriteLine(calculator.performCalculation(int.Parse(args[0]), int.Parse(args[1])));
            input = Console.ReadLine();
        }
    }
}

