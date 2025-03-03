namespace Ders03;

public class Instructor : User
{
    private string _instructorNumber;

    public string InstructorNumber
    {
        get => _instructorNumber;
        private set => _instructorNumber = value;
    }
}