// See https://aka.ms/new-console-template for more information
using OOP;

Console.WriteLine("Hello, World!");

Product product = new Product();
//product.Id = 1;
product.SetId(1);
product.Name = null;
product.UnitPrice = 5000;

//Console.WriteLine(product.Id + " " + product.Name);

Console.WriteLine(product.GetId() + " " + product.Name + " " + product.UnitPrice);


Product product1 = new Product();
product1.Id = 1;
product1.Name = "Cola";


Console.WriteLine("************************");

Category category = new Category(1,"Elektronik");
category.Id = 1;
category.Name = "Beverages";
category.CreatedDate = DateTime.Now;

CategoryManager categoryManager = new CategoryManager();
categoryManager.Add(category);

List<Category> categories = categoryManager.GetCategories();
foreach (var item in categories)
{
    Console.WriteLine(item.Id + " " + item.Name);
}