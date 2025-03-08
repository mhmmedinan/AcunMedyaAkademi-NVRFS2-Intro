namespace OOP;

public  class Product:BaseEntity<short>
{

    private string name;

    //private int Id { get; set; }
    public string Name 
    {
        get { return name;}
        
        set
        {
            if (!string.IsNullOrEmpty(value))
                name = value;
            else
                Console.WriteLine("Name alanı boş olamaz.");
        } 
    
    }

    //PascalCase
    public double UnitPrice { get; set; }


    //1.Yöntem 

    public void SetId(short id)
    {
        if (id > 0)
        {
            Id = id;
        }
    }

    public short GetId()
    {
        return Id;
    }


    //2.Yöntem
    //public string Name { get; private set; }
}


//internal => sadece aynı assembly içerisinden erişilebilir.
//protected => sadece tanımlandığı sınıf ve bu sınıftan türetilen sınıflardan erişilebilir.
//protected internal => protected ve internal erişim belirleyicilerinin birleşimidir. Yani tanımlandığı sınıf ve bu sınıftan türetilen sınıflar ile aynı assembly içerisinden erişilebilir.
//private => sadece tanımlandığı sınıf içerisinden erişilebilir.
//public => her yerden erişilebilir.