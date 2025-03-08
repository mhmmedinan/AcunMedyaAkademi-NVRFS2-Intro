using Entities;

namespace DataAccess.Abstracts;

public interface IProductRepository
{
    void Add(Product product);
    void Delete(Guid id);
    List<Product> GetAll();
}
