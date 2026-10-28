namespace Banking.Console;

public class Account
{
  public string AccountNumber;
  public string OwnerName;
  public int Balance;

  public Account(string accountNumber, string ownerName, int balance)
  {
    AccountNumber = accountNumber;
    OwnerName = ownerName;
    Balance = balance;
  }

  public void ShowInfo()
  {
    System.Console.WriteLine($"Account Number : {AccountNumber}");
    System.Console.WriteLine($"Name : {OwnerName}");
    System.Console.WriteLine($"Balance : {Balance}");
  }
}