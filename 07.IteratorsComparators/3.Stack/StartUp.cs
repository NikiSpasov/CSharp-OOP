using System;

public class Startup
{
    public static void Main()
    {
        string input = Console.ReadLine();
        CommandInterpreter intrerpret = new CommandInterpreter();
        while (input != "END")
        {
            intrerpret.Interpret(input);
            input = Console.ReadLine();
        }
        intrerpret.Interpret(input);
    }
}
