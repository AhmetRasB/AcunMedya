namespace ConsoleApp1;

public class SavingsAccount : BankAccount
{
    public override void CalculateInterest()
    {
        double interest = Balance * 0.05;
        Console.WriteLine($"Savings Account Interest: {interest}");
    }
}