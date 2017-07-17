
using System.Collections.Generic;

public class PersonClass
{
    public static void Main()
    {
        List<BankAccount> bankAccounts = new List<BankAccount>();
        
        for (int i = 0; i < 100; i++)
        {
            BankAccount one = new BankAccount
            {
                ID = 0,
                Balance = 0
            };
            one.ID += i;
            one.Balance += i;
            bankAccounts.Add(one);
        }

        Person person = new Person("Pesho", 32, bankAccounts);

        var balance = person.GetBalance();
    }
}