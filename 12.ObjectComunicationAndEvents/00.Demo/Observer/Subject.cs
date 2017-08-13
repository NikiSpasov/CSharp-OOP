using System;
using System.Collections.Generic;

public class Subject : IObservable
{
    private List<IObserver> observers;

    private int number;

    public Subject(int number)
    {
        this.Number = number;
        this.observers = new List<IObserver>();
    }
    public int Number { get; set; }

    public void Register(IObserver observer)
    {
        this.observers.Add(observer);
    }

    public void NotifyObservers()
    {
        foreach (var observer in observers)
        {
            observer.Notify(this.number);
        }
    }
}

