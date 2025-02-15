# Dotnet Genel Bilgi

- 2000 yılında microsoft tarafından çıkarılan bir programlama dilidir.
- OOP yi destekleyen (Object Oriented Programming) programlama dilidir.
- Static ve Tip Güvenliği.
- Modern ve Gelişmiş.
- Çok yönlü (Hem backend, Web, Masaüstü ve Mobil)
*** 
##### Arka Planda Dönen Şeyler
###### 1. Derleme Süreci
- .cs uzantılı dosyalar derlenir.
- C# derleyicisi (Compiler) Roslyn intermediate language kodu alır platform bağımsız koda çevirir.
- .Net Runtime IL kodunu çalışmaya hazır hale getirir.
***
###### 2. Çalışma Zamanı
- IL kodu, Common Language Runtime (CLR) tarafından çalıştırılır.
- CLR Just In Time (JIT) Compiler kullanarak IL kodunu native kod (makina koduna) çevirir.
*** 

![[Pasted image 20250215103652.png]]

***

## Dotnet Core Nedir? 

- 2016 yılında çıktı.
- Cross Platform (Windows, Linux, Macos)
- Modüler bir yapıya sahiptir.
- Açık kaynaklıdır.
***
## Dotnet Framework Nedir?

- 2002 yılında çıktı.
- Sadece windows platformlarda çalışır.
- Büyük ve kurumsal organizasyonlarda kullanıldı.
- ASP .NET MVC ve Web Formms kullanılır.
***
###### Avantaj Dezavantajlar;

- Core hızlı ve hafif.
- Core Cross Platform.
- Core Yeni teknoloji.
- Core Mikroservis uyumlu.

***
# Programlamaya Giriş

##### Veri Tipleri

```c#
//Veriables // Camel Case 
string productName = "Casper Excalibur"; 
int productPrice = 269; // 32 bit // 2 byte -2,147,483,648 2,147,483,647 
Long productPricel = 269; // 64 bit 8 byte 
byte productPrice2= 255; // 8bit 
short productPrice3 32767; 
double product Price4 = 269.99; 
float productPrice5 = 268.99F; 
decimal product Price6 = 269.98M; 
char gender = 'A';
```

- Matematiksel işlem yapılmayan her tam sayı bir string veri tipine atanır!!
***

```c#
int number1 = 10;
int number2 = 30;
if(number1 < number2){
	Console.WriteLine(number2 + "büyüktür");
}
else if(number2 < number1){
	Console.WriteLine(number1 + "büyüktür");
}
else{
	Consoole.WriteLine("Sayılar Eşit");
}
```
