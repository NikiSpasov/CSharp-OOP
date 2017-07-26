using System;
using System.Linq;

public class CommandInterpreter
{
    private ListyIterator<string> items;

    public void Interpret(string input)
    {
        string[] cmdArgs = input.Split();
        if (cmdArgs[0] == "Create")
        {
            items = new ListyIterator<string>(cmdArgs.Skip(1).ToArray());
        }
        switch (cmdArgs[0])
        {     
            case "Move":
                Console.WriteLine(items.MoveIndex());
                break;
            case "Print":
                items.Print();
                break;
            case "HasNext":
                Console.WriteLine(items.HasNext());
                break;
            case "PrintAll":
                items.PrintAll();
                break;
        }
    }
}


