using System;

public class Job
{
    public event EventHandler JobDone;

    public Job(string name, int workHoursRequired, BaseEmploee emploee)
    {
        this.Emploee = emploee;
        this.Name = name;
        this.WorkHoursRequired = workHoursRequired;    
    }

    public BaseEmploee Emploee;
    public string Name { get; private set; }
    public int WorkHoursRequired;

    public int HoursOfWorkRequired
    {
        get => this.WorkHoursRequired;
        private set => this.WorkHoursRequired = value;
    }

    public void Update()
    {
        WorkHoursRequired -= this.Emploee.WorkHoursPerWeek;
        if (this.WorkHoursRequired <= 0)
        {
            OnJobDone(new JobEventArgs(this));
        }
    }

    private void OnJobDone(EventArgs e)
    {
        if (JobDone != null)
        {
            Console.WriteLine($"Job {this.Name} done!");
            JobDone(this, e);
        }
    }

    public override string ToString()
    {
        return $"Job: {this.Name}" +
               $" Hours Remaining: " +
               $"{this.WorkHoursRequired}";
    }
}

