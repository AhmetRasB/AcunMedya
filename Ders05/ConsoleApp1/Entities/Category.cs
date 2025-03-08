using Core.Entities;

namespace Entities;

public class Category : BaseEntity
{
    public int Id { get; set; }
    public string Name { get; set; }

    public Category(int id, string name)
    {
        Id = id;
        Name = name;
    }
    public Category()
    {
        
    }
    
}