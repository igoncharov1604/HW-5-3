using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CurrentAccount : BankAccount
{
    public CurrentAccount(string accountNumber) : base(accountNumber) { }

    public override void Deposit(decimal amount)
    {
        Balance += amount;
        Console.WriteLine($"На поточний рахунок {AccountNumber} поповнено на {amount}. Баланс: {Balance}");
    }

    public override void Withdraw(decimal amount)
    {
        if (amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"З поточного рахунку {AccountNumber} знято {amount}. Баланс: {Balance}");
        }
        else
        {
            Console.WriteLine("Недостатньо коштів для зняття.");
        }
    }
}
