using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DepositAccount : BankAccount
{
    public DepositAccount(string accountNumber) : base(accountNumber) { }

    public override void Deposit(decimal amount)
    {
        Balance += amount;
        Console.WriteLine($"На депозитний рахунок {AccountNumber} поповнено на {amount}. Баланс: {Balance}");
    }

    public override void Withdraw(decimal amount)
    {
        Console.WriteLine("Зняття з депозитного рахунку недоступне.");
    }
}
