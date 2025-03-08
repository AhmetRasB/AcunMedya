namespace Ders04;

public class CategoryManager
{
    private List<Category> _categories;

    public CategoryManager()
    {
        //Singleton Pattern
        _categories = new List<Category>();
        _categories.Add(new Category(12,"Selam"));
        _categories.Add(new Category(id:2,name: "bebek"));
    }
    public void Add(Category category)
    {
        _categories.Add(category);
    }

    public List<Category> GetCategories()
    {
        return _categories;
    }
}

