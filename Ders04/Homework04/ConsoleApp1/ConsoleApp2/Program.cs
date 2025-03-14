// Diziler (Arrays), aynı türde birden fazla veriyi tek bir değişkende saklamamızı sağlar.  
// Dizilere, her elemanın belirli bir indeks (index) numarası ile erişilir.  
// Örneğin, birden fazla araba markasını farklı değişkenlerde tutmak yerine,  
// hepsini tek bir dizi içinde saklayarak daha düzenli ve yönetilebilir hale getirebiliriz.


Console.WriteLine("Lütfen 5 adet tam sayı giriniz:");

int[] dizi = new int[5];

for (int i = 0; i < dizi.Length; i++)
{
  Console.Write($"Sayı {i + 1}: ");
  dizi[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("\nGirilen sayılar:");
foreach (var item in dizi)
{
  Console.WriteLine(item);
}

int max = dizi[0];
for (int i = 1; i < dizi.Length; i++)
{
  if (dizi[i] > max)
  {
    max = dizi[i];
  }
}

Console.WriteLine($"\nEn büyük sayı: {max}");
