// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//Veriables

       //camelCase
string productName = "Casper Excalibur G770";


byte price = 255;   // 0-255 8 bit 1 byte 
short price2 = 32767; // 16 bit 2 byte
int price3 = 2147483647; // 32 bit 4 byte -2,+2
long price4 = 60000; // 64 bit 8 byte


double price5 = 299.99;
decimal price6 = 299.99M;
float price7 = 299.99F;

//int price8 = 299.99; // tam sayı olan bir veri tipine ondalıklı sayı atanamaz. 
double price9 = 50;

char gender = 'A';
bool login = false;



//Console.WriteLine(productName);
//Console.WriteLine(productName);
//Console.WriteLine(productName);
//Console.WriteLine(productName);
//Console.WriteLine(productName);
//Console.WriteLine(productName);
//Console.WriteLine(productName);
//Console.WriteLine(productName);
//Console.WriteLine(productName);
//Console.WriteLine(productName);
//Console.WriteLine(productName);

//conditials

//Console.Write("Hesap Bakiyenizi Giriniz : ");
//double accountBalance = Convert.ToDouble(Console.ReadLine());

//Console.Write("Çekmek istediğiniz miktarı giriniz : ");
//double amount = Convert.ToDouble(Console.ReadLine());

//if (amount <= accountBalance)
//{
//    accountBalance -= amount;
//    Console.WriteLine("Para çekme işlemi başarılı! Güncel bakiye" + " " + accountBalance);
//}
//else
//{
//    Console.WriteLine("Yetersiz Bakiye!");
//}


int assigment = 101;

if(assigment<=100 && assigment >= 81)
{
    Console.WriteLine("AA");
}
else if (assigment<=80 && assigment >= 71)
{
    Console.WriteLine("BA");
}
else
{
    Console.WriteLine("Geçersiz Sayı");
}


/ loops


//for,while,foreach,do while

for (int i = 0; i < 50; i++)
{
    Console.WriteLine(i);
}


for (int i = 0; i < 50; i++)
{
    if (i % 2 != 0)
    {
        Console.WriteLine($" Tek sayılar : {i}");
    }
}

//arrays
//string[]  names = new string[3];
//names[0] = "Esmanur";
//names[1] = "Sidar";
//names[2] = "Ahmet";

//for(int i = 0; i < names.Length; i++)
//{
//    Console.WriteLine(names[i]);
//}


//int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//for(int i = 0;i < numbers.Length; i++)
//{
//    Console.WriteLine(numbers[i]);
//}


//int[] numbers = new int[5];


//Console.Write("Dizi boyutunu giriniz : ");
//int arraySize = Convert.ToInt32(Console.ReadLine());

//int[] numbers = new int[arraySize];

//for (int i = 0; i < arraySize; i++)
//{
//    Console.Write($"Bir sayı giriniz  : ");
//    numbers[i] = Convert.ToInt32(Console.ReadLine());
//}

//Console.WriteLine("Girilen sayılar : ");
//foreach(var number in numbers)
//{
//    Console.WriteLine($"Sayılar : {number}");
//}


//List

//List<string> names = new List<string>();
//names.Add("Esmanur");
//names.Add("Sidar");
//names.Add("Ahmet");
//names.Add("Enes");
//foreach(var name in names)
//{
//    Console.WriteLine(name);
//}


List<string> names = new List<string> { "Esmanur", "Enes", "Ahmet", "Ahmet" };

foreach (var name in names)
{
    Console.WriteLine(name);
}

names.RemoveAll(name => name == "Ahmet");

foreach (var name in names)
{
    Console.WriteLine(name);
}




List<string> baskets = new List<string> { "Laptop", "Telefon", "Masa", "Sandalye" };

Console.Write("Silmek istediğiniz ürünü giriniz : ");
string nameToRemove = Console.ReadLine();

if (baskets.Contains(nameToRemove))
{
    baskets.Remove(nameToRemove);
    Console.WriteLine($"{nameToRemove} Adlı ürün sepetinizden silindi!");
}
else
{
    Console.WriteLine("Ürün sepetinizde bulunamadı!");
}

Console.WriteLine("Alışveriş sepetinizdeki ürünler : ");
foreach (var item in baskets)
{
    Console.WriteLine(item);
}





