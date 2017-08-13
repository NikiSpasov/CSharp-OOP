
using System;

public class Worker
{
    public delegate void WorkPerfHandler(int hours, WorkType workType);

    public event WorkPerfHandler WorkPerformed;

    public event EventHandler WorkCompleted;

    public Worker()
    {
        WorkPerformed += OnWorkPerformed;
        WorkCompleted += OnWorkCompleted;
    }

    protected void OnWorkPerformed(int hours, WorkType workType)
    {
        Console.WriteLine("Work Performed " + hours);
    }

    protected void OnWorkCompleted(object sender, EventArgs eventArgs)
    {
        WorkCompletedEventsArgs args = eventArgs as WorkCompletedEventsArgs;
        Console.WriteLine(args.WorkType + " is done");
    }    

    public virtual void DoWork(int hours, WorkType workType)
    {
        for (int i = 0; i < hours; i++)
        {
            WorkPerformed.Invoke(i + 1, workType);
        }
        WorkCompleted.Invoke(this, new WorkCompletedEventsArgs(hours, workType));
    }
}

