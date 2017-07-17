
using System.Collections.Generic;
using System.Linq;
using System.Net;

public class Person
{
    private int age;
    private string name;
    private List<BankAccount> accounts;

    public Person(string name, int age)
    : this(name, age, new List<BankAccount>())
    { }
    
    public Person(string name, int age, List<BankAccount> accounts)
    {
        this.name = name;
        this.age = age;
        this.accounts = accounts;
    }
    public double GetBalance()
    {
        return this.accounts.Sum(x => x.Balance);
    }

}

