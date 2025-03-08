namespace ConsoleApp1;

public class Developer : Employee
{
    public string About { get; set; }

    public override void CalculateBonus()
    {
        Salary *= 1.10;
        Console.WriteLine($"Developer's new salary with bonus: {Salary}");
    }
}