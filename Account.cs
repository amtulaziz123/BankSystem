public abstract class Account
{
    public string AccountNumber { get; set; }
    public double Balance { get; set; }

    // Abstract method
    public abstract void CalculateInterest();

    // Static method
    public static void DisplayBankName()
    {
        Console.WriteLine("Welcome to XYZ Bank");
    }

    // Non-static method
    public void Deposit(double amount)
    {
        Balance += amount;
        Console.WriteLine($"Deposited: {amount}, New Balance: {Balance}");
    }

    // Final method (sealed in C#)
    public sealed void ShowAccountDetails()
    {
        Console.WriteLine($"Account Number: {AccountNumber}, Balance: {Balance}");
    }
}
