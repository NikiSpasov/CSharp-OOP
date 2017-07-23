using System;

public class StartUp
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var text = Console.ReadLine();
            Box<string> currentText = new Box<string>(text);
            Console.WriteLine(currentText.ToString());
        }
    }
}

