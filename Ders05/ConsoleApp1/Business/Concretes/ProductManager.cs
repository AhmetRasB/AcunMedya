using Business.Abstracts;
using DataAccess.Concretes.InMemory;
using Entities;

namespace Business.Concretes;

public class ProductManager: IProductService
{
    public ProductManager(InMemoryProductRepository inMemoryProductRepository)
    {

    }

    public void Add(Product product)
    {
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public List<Product> getProducts()
    {
        throw new NotImplementedException();
    }
}