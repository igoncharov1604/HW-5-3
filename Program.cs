using System;

class Program
{
    static void Main()
    {
        BankAccount currentAccount = new CurrentAccount("UA1234567890");
        currentAccount.New_Account();

        currentAccount.Deposit(1000);
        currentAccount.Withdraw(500);
        currentAccount.Remove_Account();

        Console.WriteLine();

        BankAccount depositAccount = new DepositAccount("UA0987654321");
        depositAccount.New_Account();

        depositAccount.Deposit(2000);
        depositAccount.Withdraw(500); // Зняття недоступне
        depositAccount.Remove_Account();
    }
}
