// Döngüler mantıksal koşul veya koşullar karşılandığı sürece kendini yineleyen yapılardır

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
        
}

Console.WriteLine("Sayi giriniz");
int toplam = 0;
int sayi = int.Parse(Console.ReadLine());
for (int i = 0; i <= sayi; i++)
{
    toplam += i;
}

Console.WriteLine(toplam);