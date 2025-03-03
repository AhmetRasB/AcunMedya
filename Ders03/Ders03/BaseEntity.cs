namespace Ders03;

public class BaseEntity
{
    private string _id;

    public string ID
    {
        get => _id;
        private set => _id = value;
    }
}