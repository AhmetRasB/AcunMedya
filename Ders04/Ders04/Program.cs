
using Ders04;

Product product = new Product()
{
    Name = "Ahmet",
    UnitPrice = 10.00
};

// Category category = new Category();
// Console.WriteLine(category.Name);
// Console.WriteLine(product.Id);

CategoryManager categoryManager = new CategoryManager();
List<Category> categories = categoryManager.GetCategories();

foreach (var item in categories)
{
    Console.WriteLine(item.Name);
}

Category category1 = new Category();
category1.Name = "Ahmet";
category1.CreatedDate = DateTime.Now;
categoryManager.Add(category1);

foreach (var item in categories)
{
    Console.WriteLine(item.Name);
}