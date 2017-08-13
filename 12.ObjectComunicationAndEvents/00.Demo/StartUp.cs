using System;
using System.Runtime.CompilerServices;

public class StartUp
{
    public delegate void WorkPerformedDelegate(int hours, WorkType type);

    public static void Main()
    {
        Subject sub = new Subject(8);
        
        IObserver even = new EvenCalculator();

        IObserver odd = new OddCalculator();

        sub.Register(even);
        sub.Register(odd);

        for (int i = 0; i < 5; i++)
        {
            sub.Number = int.Parse(Console.ReadLine());

            sub.NotifyObservers();

            Console.WriteLine(even.Number);
            Console.WriteLine(odd.Number);
        }

















        //WorkPerformedDelegate dele0 = new WorkPerformedDelegate(WorkPerformed); // is EQUAL with:
        //WorkPerformedDelegate dele1 = WorkPerformed;

        ////dele(5, WorkType.Exam);
        //WorkPerformedDelegate dele = (h, t) =>
        //    Console.WriteLine("WorkPerformed for " + h + " hours");

        //WorkPerformedDelegate dele2 = (h, t) =>
        //    Console.WriteLine("WorkPerformed for " + t); //Without using WorkPerformed method!!!

        ////dele2(8, WorkType.Sport);

        //dele += dele2; //aggregates and then: 

        //dele(10, WorkType.Meetings); //Calls one after another!

        ////WorkPerformed for 10 hours
        ////WorkPerformed for Meetings
        /// 
        //var worker= new Worker();
        //worker.DoWork(7, WorkType.Sport);

    }

    //public static void WorkPerformed(int hours, WorkType type)
    //{
    //    Console.WriteLine("WorkPerformed for " + hours + " hours");
    //}
}


