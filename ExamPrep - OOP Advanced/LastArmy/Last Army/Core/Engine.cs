using System;
using System.Text;

public class Engine
{
    IReader reader = new ConsoleReader();
    IWriter writer = new ConsoleWriter();
    public void Run()
    {
        var input = this.reader.ReadLine();
        var gameController = new GameController();
        var result = new StringBuilder();

        while (!input.Equals("Enough! Pull back!"))
        {
            try
            {
                gameController.InterpretCommands(input);
            }
            catch (ArgumentException arg)
            {
                result.AppendLine(arg.Message);
            }
            input = this.reader.ReadLine();
        }

        writer.WriteLine(gameController.RequestResult());
    }
}

