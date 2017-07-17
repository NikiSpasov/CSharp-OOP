using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Runtime.InteropServices;
using static TestClient;

class StartUp
{
    static void Main()
    {
        var input = Console.ReadLine();

        Dictionary<int, BankAccount> accounts = new Dictionary<int, BankAccount>();

        while (input != "End")
        {
            var cmdArgs = input.Split();
            var cmdType  = cmdArgs[0];
            
            switch (cmdType)
            {
                case "Create":
                    Create(cmdArgs, accounts);
                    break;
                case "Deposit":
                    Deposit(cmdArgs, accounts);
                    break;
                case "Withdraw":
                    Withdraw(cmdArgs, accounts);
                    break;
                case "Print":
                    Print(cmdArgs, accounts);
                    break;
                default:
                    Console.WriteLine("Bad input!");
                    return;
            }
            input = Console.ReadLine();
        }
    }

}
