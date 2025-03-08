using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using DataAccess.Concretes.InMemory;
using Entities;

namespace Business;

public class ProductManager
{
    private IProductRepository _repository;
    public ProductManager(IProductRepository productRepository)
    {
        _repository = productRepository;
    }
    public void Add(Product product)
    {
        if(product.UnitPrice < 0)
        {
            throw new Exception("Ürün fiyatı sıfırdan küçük olamaz");
        }
        else
        {
            _repository.Add(product);
        }
        
    }
}