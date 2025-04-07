class Program
{
    static void Main(string[] args)
    {
        // Using static method
        Account.DisplayBankName();

        // Creating an instance of SavingsAccount
        SavingsAccount savings = new SavingsAccount
        {
            AccountNumber = "123456789",
            Balance = 1000.0
        };

        // Using non-static method
        savings.Deposit(500);

        // Using abstract method
        savings.CalculateInterest();

        // Using final method
        savings.ShowAccountDetails();
    }
}
