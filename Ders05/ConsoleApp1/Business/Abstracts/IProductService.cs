using Entities;

namespace Business.Abstracts;

public interface IProductService
{
    void Add(Product product);
    void Delete(int id);
    List<Product> getProducts();
}