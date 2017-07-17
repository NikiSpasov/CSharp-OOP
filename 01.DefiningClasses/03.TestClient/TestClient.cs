using System;
using System.Collections.Generic;

public class TestClient
{
    public static void Create(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
    {
        var id = int.Parse(cmdArgs[1]);
        if (accounts.ContainsKey(id))
        {
            Console.WriteLine("Account already exists");
        }
        else
        {
            var acc = new BankAccount();
            acc.ID = id;
            accounts.Add(id, acc);
        }
    }

    public static void Deposit(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
    {
        var accIdForDeposit = int.Parse(cmdArgs[1]);
        var depositSum = double.Parse(cmdArgs[2]);
        if (accounts.ContainsKey(accIdForDeposit))
        {
            accounts[accIdForDeposit].Deposit(depositSum);
        }
        else
        {
            Console.WriteLine("Account does not exist");
        }
    }

    public static void Withdraw(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
    {
        var accIdForWithdraw = int.Parse(cmdArgs[1]);
        var sum = double.Parse(cmdArgs[2]);
        if (!accounts.ContainsKey(accIdForWithdraw))
        {
            Console.WriteLine("Account does not exist");
        }
        else
        {
            if (accounts[accIdForWithdraw].Balance >= sum)
            {
                accounts[accIdForWithdraw].Withdraw(sum);
            }
            else
            {
                Console.WriteLine("Insufficient balance");
            }
        }
    }

    public static void Print(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
    {
        var accIdForPrint = int.Parse(cmdArgs[1]);
        if (!accounts.ContainsKey(accIdForPrint))
        {
            Console.WriteLine("Account does not exist");
        }
        else
        {
            Console.WriteLine(accounts[accIdForPrint].ToString());
        }
    }
}

