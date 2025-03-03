namespace Ders03;

public class Student : User
{
    private string _studentNumber;

    public string StudentNumber
    {
        get => _studentNumber;
        private set => _studentNumber = value;
    }
}




