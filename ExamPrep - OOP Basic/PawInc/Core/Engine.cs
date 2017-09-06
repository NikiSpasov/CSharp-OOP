using System;

public class Engine
{
    public void Run()
    {
        CommandInterpreter interpreter = new CommandInterpreter();

        string input;
        while ((input = Console.ReadLine()) != "Paw Paw Pawah")
        {
            string[] args = input.Split(new[] {" | "}, StringSplitOptions.RemoveEmptyEntries);
            interpreter.interpret(args);
        }

        interpreter.interpret(new []{"Paw"});
    }
}

