using System;

public class StartUp
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var num = int.Parse(Console.ReadLine());
            Box<int> currentText = new Box<int>(num);
            Console.WriteLine(currentText.ToString());
        }
    }
}