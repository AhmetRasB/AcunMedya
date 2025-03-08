namespace ConsoleApp1;

public class CheckingAccount : BankAccount
{
    public override void CalculateInterest()
    {
        Console.WriteLine("Checking accounts do not earn interest.");
    }
}