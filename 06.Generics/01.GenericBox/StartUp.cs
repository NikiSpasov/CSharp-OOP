public class StartUp
{
    public static void Main()
    {
        Box<string> myBox = new Box<string>("life in a box");
        System.Console.WriteLine(myBox.ToString());
    }
}

