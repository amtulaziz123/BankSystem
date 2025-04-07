public class SavingsAccount : Account
{
    private const double InterestRate = 0.05;

    // Implementing abstract method
    public override void CalculateInterest()
    {
        double interest = Balance * InterestRate;
        Balance += interest;
        Console.WriteLine($"Interest: {interest}, New Balance: {Balance}");
    }
}
