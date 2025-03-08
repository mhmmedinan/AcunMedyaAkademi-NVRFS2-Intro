using DataAccess.Abstracts;
using Entities;

namespace DataAccess.Concretes.InMemory;

public class InMemoryProductRepository:IProductRepository
{
    private List<Product> _products;

    public InMemoryProductRepository()
    {
        _products = new List<Product>();

        //Seed Data
        _products.Add(new Product(Guid.NewGuid(), "Samsung S5", 1000, "Good Phone", new Category(1, "Phone")));
        _products.Add(new Product(Guid.NewGuid(), "Samsung S6", 2000, "Good Phone", new Category(1, "Phone")));
        _products.Add(new Product(Guid.NewGuid(), "Samsung S7", 3000, "Good Phone", new Category(1, "Phone")));
    }


    public void Add(Product product)
    {
        Console.WriteLine("Product added to InMemory");
        _products.Add(product);
    }

    public void Delete(Guid id)
    {
        Console.WriteLine("Product deleted from InMemory");
        Product? product = _products.FirstOrDefault(p => p.Id == id);
        if (product is not null)
            _products.Remove(product);
    }

    public List<Product> GetAll()
    {
        Console.WriteLine("Products returned from InMemory");
        return _products;
    }
}
