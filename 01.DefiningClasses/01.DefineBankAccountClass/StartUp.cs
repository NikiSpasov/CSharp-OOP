using System;

public class StartUp
{
    public static void Main()
    {
        BankAccount acc = new BankAccount();

        acc.ID = 1;
        acc.Balance = 15;


        Console.WriteLine($"Acccount {acc.ID}, balance {acc.Balance}");

    }
}

