using System;
using System.Linq;

public class CommandInterpreter
{
    private Stack<int> numbers;

    public CommandInterpreter()
    {
        numbers = new Stack<int>();
    }
    public void Interpret(string input)
    {
        string[] cmdArgs = input.Split();
        switch (cmdArgs[0])
        {
            case "Push":
                int[] cmdArgsNumsForPush = input
                    .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Skip(1)
                    .Select(int.Parse)
                    .ToArray();
                numbers.Push(cmdArgsNumsForPush);
                break;
            case "Pop":
                numbers.Pop();
                break;
            case "END":
                if (numbers.Count() == 0)
                {
                    break;
                }
                foreach (var num in numbers)
                {
                    Console.WriteLine(num);
                }
                break;
        }
    }
}


