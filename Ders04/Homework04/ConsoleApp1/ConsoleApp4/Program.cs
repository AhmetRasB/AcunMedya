// İf else belirli bir ifade çalışmadığında olacak başka koşulları göstermek ve
// hangi koşulda ne yapacağını tanımlamak için kullanılan bir yapıdır.
Console.WriteLine("Sayi giriniz");
int sayi = int.Parse(Console.ReadLine());
if (sayi % 2 == 0)
{
    Console.WriteLine("Sayi cifttir");
}
else
{
    Console.WriteLine("Sayi tektir");
}


Console.WriteLine("Sayi giriniz");
int sayi2 = int.Parse(Console.ReadLine());

if (sayi2 == 0)
{
    Console.WriteLine("Sayi 0 dir");
}
else if(sayi2 > 0)
{
    Console.WriteLine("Sayi Pozitif");
}
else if (sayi2 < 0)
{
    Console.WriteLine("Sayi negatiftir");
}