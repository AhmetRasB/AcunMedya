// See https://aka.ms/new-console-template for more information

using ConsoleApp1;

Manager manager = new Manager()
{
    Name = "John Doe",
    Id = 5,
    Salary = 2500,
    TeamSize = 15
};

manager.CalculateBonus();

Developer developer = new Developer()
{
    Name = "Jane Smith",
    Id = 6,
    Salary = 2000,
    About = "Backend Developer"
};

developer.CalculateBonus();

SavingsAccount savingsAccount = new SavingsAccount()
{
    Balance = 1500,
    AccountHolder = "John Doe",
};

savingsAccount.CalculateInterest();

CheckingAccount checkingAccount = new CheckingAccount()
{
    Balance = 1000,
    AccountHolder = "Jane Smith",
};

checkingAccount.CalculateInterest();