namespace Mart1Odev.Entities;

public class ProgrammingLanguage
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Technology> Technologies { get; set; } = new();
}