namespace ConsoleApp1;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Salary { get; set; }
    public string Department { get; set; }

    public virtual void CalculateBonus()
    {
        Console.WriteLine("Basic salary");
    }
}