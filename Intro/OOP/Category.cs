namespace OOP;

//Inheritance: Bir sınıfın başka bir sınıftan özelliklerini almasıdır.
public class Category:BaseEntity<int>
{
    public string Name { get; set; }


    public Category()
    {
        Name = string.Empty!;
    }
    
    public Category(int id,string name)
    {
        Id = id;
        Name = name;
    }
}
