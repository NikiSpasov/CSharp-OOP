using System;

public class Engine
{
    public void Run()
    {
        CommInterpret interpreter = new CommInterpret();

        string input = Console.ReadLine();

        while (input != "END")
        {
            interpreter.Interpret(input);
            input = Console.ReadLine();
        }
    }
}

