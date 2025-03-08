namespace ConsoleApp1;

public class BankAccount
{
    public string AccountHolder { get; set; }
    public double Balance { get; set; }

    public virtual void CalculateInterest()
    {
    }
}