using System;

public class Engine
{
    public void Run()
    {
        CommandInterpretet interpreter = new CommandInterpretet();
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {  
            interpreter.Interpret();
        }
    }
}

