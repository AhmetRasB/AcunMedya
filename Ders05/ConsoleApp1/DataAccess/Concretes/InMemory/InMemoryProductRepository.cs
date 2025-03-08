using System.Security.Cryptography.X509Certificates;
using Entities;

namespace DataAccess.Concretes.InMemory;

public class InMemoryProductRepository
{
    private List<Product> _products;
    //public void Add(Product product)
    //{
    //    _product = new List<Product>
    //    {
    //        new Product()
    //        {
    //            Category = new Category(1, "Beverages"),
    //            Name = "Chai",
    //            UnitPrice = 18.0m,
    //            Description = "10 boxes x 20 bags"

    //        }
    //    };
    //}

    public void Add(Product product)
    {
        _products.Add(product);
    }

    public void Delete(int id)
    {
        Product? product = _products.FirstOrDefault(p => p.Id == id);
        if (product != null)
        {
            _products.Remove(product);
        }
    }
}