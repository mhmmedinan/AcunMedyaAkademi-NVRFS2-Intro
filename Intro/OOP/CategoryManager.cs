namespace OOP;

public class CategoryManager
{
    private List<Category> _categories;

    //Constructor => Yapıcı Metot

    public CategoryManager()
    {
        //IOC Container => Inversion of Control
        //Dependency Injection - Singleton Pattern
        _categories = new List<Category>();
        _categories.Add(new Category(1, "Beverages")); //Constructor ile ekledik.
        _categories.Add(new Category { Id= 2,Name= "Condiments" });
    }


    


    public void Add(Category category)
    {
        //List<Category> categories = new List<Category>();
        _categories.Add(category);
    }


    public List<Category> GetCategories()
    {
       // List<Category> categories = new List<Category>();
        return _categories;
    }


    // kötü kodlama pratiği

    //public void Add()
    //{
    //    Category category = new Category();
    //    category.Id = 1;
    //    category.Name = "Beverages";
    //    category.CreatedDate = DateTime.Now;

    //    Console.WriteLine("Category Added" + category.Name);
    //}


    //public void Add(Category category)
    //{
    //    //List<Category> categories = new List<Category>();
    //    categories.Add(category);
    //}


    //public List<Category> GetCategories()
    //{
    //    // List<Category> categories = new List<Category>();
    //    return categories;
    //}



    //Customer => Individual and Corporate
    //IndividualCustomerManager adında sınıf oluşturunuz.
    //Add,Getlist,Delete,GetById metotlarını ekleyiniz.



}
