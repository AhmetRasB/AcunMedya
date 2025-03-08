namespace ConsoleApp1;

public class Manager : Employee
{
    public int TeamSize { get; set; }

    public override void CalculateBonus()
    {
        Salary *= 0.80;
        Console.WriteLine($"Salary =  {Salary}");
    }
}