using System;

public class Engine
{
    Smartphone smartPhone = new Smartphone();
    public void Run()
    {
        string[] phones = Console.ReadLine().Split(new[] {' '});
        smartPhone.Call(phones);
        string[] sites = Console.ReadLine().Split(new[] {' '});
        smartPhone.Browse(sites);
    }
}

