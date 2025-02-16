#region Sayinin Pozitif,Negatif veya Sıfır Oldugunu Belirleme(if-else)
Console.WriteLine("Sayiyi giriniz");
int sayi = int.Parse(Console.ReadLine());
if (sayi > 0)
{
    Console.WriteLine("Sayi pozitif");
}
else if (sayi < 0)
{
    Console.WriteLine("Sayi negatif");
}
else
{
    Console.WriteLine("Sayi sifir");
}
#endregion

#region Gun Ismi Belirleme(switch-case)

Console.WriteLine("Lutfen Gun Ismini Giriniz");
string gun = Console.ReadLine();
switch (gun)
{
    case "Pazartesi":
        Console.WriteLine("1.Gun");
        break;
    case "Sali":
        Console.WriteLine("2.Gun");
        break;
    case "Carsamba":
        Console.WriteLine("3.Gun");
        break;
    case "Persembe":
        Console.WriteLine("4.Gun");
        break;
    case "Cuma":
        Console.WriteLine("5.Gun");
        break;
    case "Cumartesi":
        Console.WriteLine("6.Gun");
        break;
    case "Pazar":
        Console.WriteLine("7.Gun");
        break;
    default:
        Console.WriteLine("Hatali Giris");
        break;
}

#endregion

#region Basit Hesap Makinasi (switch-case)

Console.WriteLine("2 Adet Sayi giriniz");
int sayi1 = int.Parse(Console.ReadLine());
int sayi2 = int.Parse(Console.ReadLine());
Console.WriteLine("Islem Seciniz");
Console.WriteLine("1-Toplama");
Console.WriteLine("2-Cikarma");
Console.WriteLine("3-Carpma");
Console.WriteLine("4-Bolme");
int secim = int.Parse(Console.ReadLine());
switch (secim)
{
    case 1:
        Console.WriteLine("Sonuc:" + (sayi1 + sayi2));
        break;
    case 2:
        Console.WriteLine("Sonuc:" + (sayi1 - sayi2));
        break;
    case 3:
        Console.WriteLine("Sonuc:" + (sayi1 * sayi2));
        break;
    case 4:
        Console.WriteLine("Sonuc:" + (sayi1 / sayi2));
        break;
    default:
        Console.WriteLine("Hatali Giris");
        break;
}

#endregion

#region Uc Sayinin En Buyugunu Bulma (if-else)

Console.WriteLine("Uc adet sayi giriniz");
int usayi1 = int.Parse(Console.ReadLine());
int usayi2 = int.Parse(Console.ReadLine());
int usayi3 = int.Parse(Console.ReadLine());

if (usayi1 > usayi2 && usayi1 > usayi3)
{
    Console.WriteLine("En Buyuk Sayi:" + usayi1);
}
else if (usayi2 > usayi1 && usayi2 > usayi3)
{
    Console.WriteLine("En Buyuk Sayi:" + usayi2);
}
else
{
    Console.WriteLine("En Buyuk Sayi:" + usayi3);
}
#endregion

#region Sifre Guclulugunu Kontrol Etme (if-else)

Console.WriteLine("Şifre Giriniz\nGüçlü Şifre Kriterleri: \n - 8 karakterden uzun olmalı \n - Özel karakter içermeli (@ # $ % & *) \n - En az bir büyük harf içermeli ");
string? sifre = Console.ReadLine();

if (sifre == null)
{
    Console.WriteLine("Şifre boş olamaz!");
    return;
}

bool uzunlukUygun = sifre.Length > 8;
bool ozelKarakterVar = sifre.Any(c => "@#$%&*".Contains(c));
bool buyukHarfVar = sifre.Any(c => char.IsUpper(c));

if (uzunlukUygun && ozelKarakterVar && buyukHarfVar)
{
    Console.WriteLine("Başarılı! Şifreniz: " + sifre);
}
else
{
    Console.WriteLine("Şifreniz güçsüz. Lütfen kriterlere uygun bir şifre girin.");
}
#endregion