

#region For dongusu ile sayinin rakamlarinin toplamini buan algoritmayi yaziniz

Console.WriteLine("Lütfen bir sayı giriniz");
int sayi = int.Parse(Console.ReadLine());
int toplam = 0;

for (; sayi > 0; sayi /= 10)
{
    toplam += sayi % 10;
}

Console.WriteLine("Rakamlarin toplami " + toplam);

#endregion

#region Kullanicidan belirli sartlara uyan bir deger alan algoritmayi yaziniz(10 ile 100 arasinda bir sayi al) 

while (true)
{
    Console.WriteLine("10 ile 100 arasinda bir sayi giriniz");
    int number = int.Parse(Console.ReadLine());

    if (10 >= number && number <=100)
    {
        Console.WriteLine("Sayi gecerlidir");
        break;
    }

    else
    {
        Console.WriteLine("Hatali giris, lutfen 10 ile 100 arasi bir sayi giriniz");
    }
}



#endregion

#region Foreach dongusu ile kisilerin yas kategorisini belirleyen algoritmayi yaziniz(0-12 cocuk, 13-19 genc, 20-64 yetiskin, 65+ yasli)

List<int> yaslar = new List<int> { 10, 15, 25, 70 };

foreach (var yas in yaslar)
{
    if (yas >= 0 && yas <= 12)
    {
        Console.WriteLine("Cocuk");
    }
    else if (yas >= 13 && yas <= 19)
    {
        Console.WriteLine("Genc");
    }
    else if (yas >= 20 && yas <= 64)
    {
        Console.WriteLine("Yetiskin");
    }
    else
    {
        Console.WriteLine("Yasli");
    }
}

#endregion



#region Bir dizide tekrar eden elemanlari bulunuz

int[] sayilar = { 15, 20, 25, 30, 30, 40, 40, 60 };

for(int i = 0; i < sayilar.Length; i++)
{
    for (int j = i + 1; j < sayilar.Length; j++)
    {
        if (sayilar[i] == sayilar[j])
        {
            Console.WriteLine("Tekrar eden eleman: " + sayilar[i]);
        }
    }
}

#endregion





#region Bir dizideki en uzun ve en kisa kelimeyi bulan algoritmayi yaziniz

string[] kelimeler = { "elma", "armut", "kiraz", "karpuz", "muz" , "abuzer" , "a" };

string enUzunKelime = kelimeler[0];
string enKisaKelime = kelimeler[0];
if (kelimeler.Length > 1)
{
    for (int i = 1; i < kelimeler.Length; i++)
    {
        if (kelimeler[i].Length > enUzunKelime.Length)
        {
            enUzunKelime = kelimeler[i];

            
        }
        if (kelimeler[i].Length < enKisaKelime.Length)
        {
            enKisaKelime = kelimeler[i];
        }
    }
    Console.WriteLine("En uzun kelime : " + enUzunKelime + "\n En kisa kelime : " + enKisaKelime);
}

#endregion



#region Girilen cumledeki kelimeleri alfabetik olarak sirala

Console.WriteLine("Lutfen bir cumle giriniz");
string cumle = Console.ReadLine();
string[] dizi = cumle.Split(" ");
Array.Sort(dizi);
Console.WriteLine(string.Join(" ", dizi));

#endregion



#region Bir string dizisinin boyutunu dinamik olarak genisleten algoritmayi yaziniz

string[] dizi = {"ahmet","mehmet","hasan"};
Console.WriteLine("Normal dizi : " + string.Join(", ", dizi));

Array.Resize(ref dizi, dizi.Length + 1);
dizi[dizi.Length - 1] = "ali";

Console.WriteLine("Genisletilmis dizi  : " + string.Join(", ", dizi));

#endregion



#region Kullanicidan girdigi kelimeleri listeye kaydeden ve tersten yazdiran algoritmayi yaziniz

List<string> kelimeler = new List<string>();
Console.WriteLine("Kelime girin, cikmak icin exit yazin");
while (true)
{
    Console.WriteLine("Kelime :");
    string kelime = Console.ReadLine();
    if(kelime.ToLower() == "exit")
    {
        break;
    }

    kelimeler.Add(kelime);
}

kelimeler.Reverse();
Console.WriteLine("Tersten kelimeler");
foreach (var kelime in kelimeler)
{
    Console.WriteLine(kelime);
}


#endregion


#region Kullanicidan rastgele sayilar alip listeye ekleyen, bu sayilarin ortalamasini alan ve bu sayilari kucukten buyuge siralayan algoritmayi yaziniz

Console.Write("Sayılari girin (boşlukla ayırarak): ");
string input = Console.ReadLine();
string[] sayilarStr = input.Split(' ');

List<int> sayilar = new List<int>();
foreach (string sayiStr in sayilarStr)
{
    int sayi = Convert.ToInt32(sayiStr);
    sayilar.Add(sayi);
}
int toplam = 0;
foreach (int sayi in sayilar)
{
    toplam += sayi;
}
double ortalama = (double)toplam / sayilar.Count;
Console.WriteLine("Girilen sayıların ortalaması: " + ortalama);
sayilar.Sort(); 
Console.WriteLine("Sayılar kucukten buyuge sıralandı:");
foreach (int sayi in sayilar)
{
    Console.WriteLine(sayi);
}

#endregion


#region Rastgele Sayılar ile Liste İşlemleri
List<int> sayilar = new List<int>();
Console.Write("Kaç adet sayı gireceksiniz? ");
int adet = int.Parse(Console.ReadLine());

for (int i = 0; i < adet; i++)
{
    Console.Write($"Sayı {i + 1}: ");
    sayilar.Add(int.Parse(Console.ReadLine()));
}

double ortalama = sayilar.Average();
sayilar.Sort();

Console.WriteLine($"Ortalama: {ortalama}");
Console.WriteLine("Küçükten büyüğe sıralı liste: " + string.Join(", ", sayilar));

#endregion



#region  10’dan Küçük Sayıları Silme

List<int> sayilar = new List<int> { 3, 12, 7, 25, 10, 5, 18 };

sayilar.RemoveAll(sayi => sayi < 10);

Console.WriteLine("10'dan küçük olanlar silindi: " + string.Join(", ", sayilar));

#endregion



#region 50’nin Altındaki Notları Güncelleme

List<int> notlar = new List<int> { 45, 60, 30, 75, 49, 90 };

for (int i = 0; i < notlar.Count; i++)
{
    if (notlar[i] < 50)
        notlar[i] = 50;
}

Console.WriteLine("Güncellenmiş notlar: " + string.Join(", ", notlar));

#endregion



#region  Metot (Fonksiyon) Nedir?

// Metotlar, programlama dillerinde belirli bir işlevi yerine getiren kod bloklarıdır.

#endregion

#region Metotları Neden Kullanırız

// Kodun tekrar kullanılabilirliğini sağlar.
// Kodun daha okunabilir ve düzenli olmasını sağlar.
// Kodun daha kolay yönetilmesini sağlar.

#endregion

#region Geriye Değer Döndüren Metot ile Void Metot Arasındaki Fark

// Geriye değer döndüren metotlar, bir değer döndürür ve bu değeri kullanabiliriz.
// Void metotlar ise bir değer döndürmez ve sadece belirli bir işlemi gerçekleştirir.


#endregion


#region Metotların Parametreleri Nasıl Çalışır?

static void Selamla(string isim)
{
    Console.WriteLine($"Merhaba, {isim}!");
}

static void Main()
{
    Selamla("Ahmet");  
}
#endregion