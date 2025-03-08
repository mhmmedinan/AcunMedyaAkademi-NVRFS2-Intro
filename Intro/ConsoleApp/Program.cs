// See https://aka.ms/new-console-template for more information
using Business.Abstracts;
using Business.Concretes;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using DataAccess.Concretes.InMemory;
using Entities;

Console.WriteLine("Hello, World!");


IProductService productService = new ProductManager(new InMemoryProductRepository());

List<Product> products = productService.GetProducts();
foreach (var product in products)
{
    Console.WriteLine(product.Name);
}

