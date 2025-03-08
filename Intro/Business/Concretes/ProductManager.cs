using Business.Abstracts;
using DataAccess.Abstracts;
using Entities;

namespace Business.Concretes;

public class ProductManager : IProductService
{

    private readonly IProductRepository _productRepository;


    //Dependency Injection
    //Loose coupling
    public ProductManager(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public List<Product> GetProducts()
    {
        return _productRepository.GetAll();
    }

    public void AddProduct(Product product)
    {
        if (product.UnitPrice < 0)
            throw new Exception("Unit price can not be less than 0");

        _productRepository.Add(product);
    }
}
