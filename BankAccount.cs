using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class BankAccount : IAccountManagement
{
    public string AccountNumber { get; protected set; }
    public decimal Balance { get; protected set; }

    public BankAccount(string accountNumber)
    {
        AccountNumber = accountNumber;
        Balance = 0;
    }

    public virtual void New_Account()
    {
        // Реалізація логіки для створення нового рахунку
        Console.WriteLine($"Новий рахунок створено: {AccountNumber}");
    }

    public virtual void Remove_Account()
    {
        // Реалізація логіки для видалення рахунку
        Console.WriteLine($"Рахунок видалено: {AccountNumber}");
    }

    public abstract void Deposit(decimal amount);
    public abstract void Withdraw(decimal amount);
}