
using System;
using System.Collections.Generic;
using System.Linq;

public class Engine
{
    private DraftManager manager = new DraftManager();

    public Engine()
    {
        this.manager = new DraftManager();
    }

    public void Run()
    {
        string command = String.Empty;

        while ((command = Console.ReadLine()) != "Shutdown")
        {
            var cmdArgs = command.Split(' ').ToList();
            ExecuteCommand(cmdArgs);
        }
        Console.WriteLine(
        manager.ShutDown());
    }

    public void ExecuteCommand(List<string> cmdArgs)
    {

        switch (cmdArgs[0])
        {
            case "RegisterHarvester":
                Console.WriteLine(
                manager.RegisterHarvester(cmdArgs));
                break;

            case "RegisterProvider":
                Console.WriteLine(
                manager.RegisterProvider(cmdArgs));
                break;

            case "Mode":
                Console.WriteLine(
                manager.Mode(cmdArgs));
                break;

            case "Day":
                Console.WriteLine(
                manager.Day());
                break;
            case "Check":
                Console.WriteLine(
                manager.Check(cmdArgs));
                break;
            case "Shutdown":
                Console.WriteLine(
                manager.ShutDown());
                break;
        }
    }
}

