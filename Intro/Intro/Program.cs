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




