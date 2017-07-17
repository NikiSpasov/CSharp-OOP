using System;

public class StartUp
{
    public static void Main()
    {

        Shape circle = new Circle(12);
        Shape rectangle = new Rectangle(4, 5);

        Console.WriteLine(circle.CalculateArea());
        Console.WriteLine(rectangle.CalculateArea());
        Console.WriteLine(rectangle.CalculatePerimeter());
        Console.WriteLine(rectangle.Draw());
        Console.WriteLine(circle.Draw());
    }
}

