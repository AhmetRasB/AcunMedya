namespace Ders04;

public class Category:BaseEntity<int>
{
   
    public string Name { get; set; }
    
    // Constructors new metodu yapıcı metoddur
    public Category()
    {
        Name = string.Empty!;
        Id++;
    }

    public Category(int id, string name)
    {
        Name = name;
    }


}