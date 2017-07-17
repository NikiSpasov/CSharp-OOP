using System;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

public class BankAccount
{
    private int id;
    private double balance;


    public int ID;
    public double Balance;
    public BankAccount()
    {
        ID = this.id;
        Balance = this.balance;
    }

    public void Deposit(double amount)
    {
        this.balance += amount;
    }

    public void Withdraw(double amount)
    {
        this.balance -= amount;
    }

    public override string ToString()
    {
        return $"Account ID{ID}, balance {this.balance}";
    }
}