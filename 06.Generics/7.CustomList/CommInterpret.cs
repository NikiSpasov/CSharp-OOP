
using System;

class CommInterpret
{
    Box<string> item = new Box<string>("");

    public void Interpret(string input)
    {
        string[] args = input.Split(' ');
        string command = args[0];
        switch (command)
        {
            case "Add" :
            item.Add(args[1]);
                break;
            case "Remove" :
                item.Remove(int.Parse(args[1]));
                break;
            case "Contains":
                Console.WriteLine(
                item.Contains(args[1]));
                break;
            case "Swap":
                item.Swap(int.Parse(args[1]), int.Parse(args[2]));
                break;
            case "Greater" :
                Console.WriteLine(
                item.CountGreaterThan(args[1]));
                break;
            case "Max" :
                item.Max();
                break;
            case "Min" :
                item.Min();
                break;
            case "Print":
                item.Print();
                break;

            default:
                Console.WriteLine("Not a valid command.");
                return;
        }
    }
}

