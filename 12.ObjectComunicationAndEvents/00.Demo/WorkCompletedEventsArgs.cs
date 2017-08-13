
using System;
public class WorkCompletedEventsArgs : EventArgs
{
    public WorkCompletedEventsArgs(int hours, WorkType workType)
    {
        this.WorkType = workType;
        this.Hours = hours;
    }
    public int Hours { get; set; }
    public WorkType WorkType { get; set; }
}

