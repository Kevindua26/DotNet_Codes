using System;

namespace DotNet
{
  // Q36: Payment system with interface, abstract base, and concrete implementations
  public class Q36_PaymentSystem
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("-- Q36 Payment System Demo --");
      IPaymentMethod[] methods = new IPaymentMethod[] {
                new CreditCardPayment("Visa", "4242-4242-4242-4242", "12/25", "123"),
                new PayPalPayment("user@paypal.com"),
                new BankTransferPayment("Bank of Demo", "123456789")
            };

      foreach (var m in methods)
      {
        Console.WriteLine($"Method: {m.GetPaymentMethodName()}");
        Console.WriteLine($"Valid: {m.ValidatePaymentDetails()}");
        m.ProcessPayment();
        Console.WriteLine($"Fees: {(m is PaymentMethodBase p ? p.CalculateTransactionFees() : 0):C}");
        Console.WriteLine();
      }
    }
  }

  public interface IPaymentMethod
  {
    bool ValidatePaymentDetails();
    void ProcessPayment();
    string GetPaymentMethodName();
  }

  public abstract class PaymentMethodBase : IPaymentMethod
  {
    protected string paymentMethodName;
    public PaymentMethodBase(string name) { paymentMethodName = name; }
    public string GetPaymentMethodName() => paymentMethodName;
    public abstract bool ValidatePaymentDetails();
    public abstract void ProcessPayment();
    public abstract double CalculateTransactionFees();
  }

  public class CreditCardPayment : PaymentMethodBase
  {
    private string cardNumber, expiry, cvv;
    public CreditCardPayment(string name, string cardNumber, string expiry, string cvv) : base(name)
    {
      this.cardNumber = cardNumber; this.expiry = expiry; this.cvv = cvv;
    }

    public override bool ValidatePaymentDetails()
    {
      return !string.IsNullOrWhiteSpace(cardNumber) && cardNumber.Length >= 12;
    }

    public override void ProcessPayment()
    {
      Console.WriteLine($"Processing credit card payment with {paymentMethodName}...");
    }

    public override double CalculateTransactionFees() => 0.02; // 2%
  }

  public class PayPalPayment : PaymentMethodBase
  {
    private string email;
    public PayPalPayment(string email) : base("PayPal") { this.email = email; }
    public override bool ValidatePaymentDetails() => email.Contains("@");
    public override void ProcessPayment() => Console.WriteLine("Processing PayPal payment...");
    public override double CalculateTransactionFees() => 0.03; // 3%
  }

  public class BankTransferPayment : PaymentMethodBase
  {
    private string bankName, accountNumber;
    public BankTransferPayment(string bankName, string accountNumber) : base("Bank Transfer") { this.bankName = bankName; this.accountNumber = accountNumber; }
    public override bool ValidatePaymentDetails() => accountNumber.Length >= 6;
    public override void ProcessPayment() => Console.WriteLine("Processing bank transfer payment...");
    public override double CalculateTransactionFees() => 0.005; // 0.5%
  }
}
