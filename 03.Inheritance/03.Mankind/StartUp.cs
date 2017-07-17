using System;

public class StartUp
{
    static void Main()
    {
        try
        {
            string[] infoForStudent = Console.ReadLine()
                .Trim()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string[] infoForWorker = Console.ReadLine()
                .Trim()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Student student = new Student(infoForStudent[0], infoForStudent[1], infoForStudent[2]);
            Worker worker = new Worker(
                infoForWorker[0],
                infoForWorker[1],
                decimal.Parse(infoForWorker[2]),
                decimal.Parse(infoForWorker[3])
            );

            Console.WriteLine(student);

            Console.WriteLine(worker);
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine(ae.Message);
        }
    }
}
