namespace Ders03;

public class User : BaseEntity
{
    private string _email;
    private string _password;
    private string _firstName;
    private string _lastName;

    public string Email
    {
        get => _email;
        private set => _email = value;
    }

    public string Password
    {
        get => _password;
        private set => _password = value;
    }

    public string FirstName
    {
        get => _firstName;
        private set => _firstName = value;
    }

    public string LastName
    {
        get => _lastName;
        private set => _lastName = value;
    }
}