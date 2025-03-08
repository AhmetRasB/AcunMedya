

using System.Threading.Channels;
using Business.Abstracts;
using Business.Concretes;
using DataAccess.Concretes.InMemory;
using Entities;

IProductService productService = new ProductManager(new InMemoryProductRepository());
List<Product> products = productService.getProducts();

foreach (var item in products)
{
    Console.WriteLine(item.Name);
}