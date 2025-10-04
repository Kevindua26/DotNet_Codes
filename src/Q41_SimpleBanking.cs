using System;

namespace DotNet
{
  // Q41: Simple banking application
  public class Q41_SimpleBanking
  {
    public static void Main(string[] args)
    {
      var account = new BankAccount("12345", "John Doe");
      account.Deposit(500);
      account.Withdraw(120);
      Console.WriteLine($"Balance: {account.Balance:C}");
    }
  }

  public class BankAccount
  {
    public string AccountNumber { get; }
    public string Owner { get; }
    public decimal Balance { get; private set; }

    public BankAccount(string accNumber, string owner)
    {
      AccountNumber = accNumber; Owner = owner; Balance = 0m;
    }

    public void Deposit(decimal amount)
    {
      if (amount <= 0) throw new ArgumentException("Amount must be positive");
      Balance += amount;
      Console.WriteLine($"Deposited {amount:C}");
    }

    public void Withdraw(decimal amount)
    {
      if (amount <= 0) throw new ArgumentException("Amount must be positive");
      if (amount > Balance) throw new InvalidOperationException("Insufficient funds");
      Balance -= amount;
      Console.WriteLine($"Withdrew {amount:C}");
    }
  }
}
