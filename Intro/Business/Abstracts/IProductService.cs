using Entities;

namespace Business.Abstracts;

public interface IProductService
{
    void AddProduct(Product product);
    List<Product> GetProducts();
}
