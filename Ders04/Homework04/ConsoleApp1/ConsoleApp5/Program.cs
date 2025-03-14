// Temel veri tipleri int tam sayı double ve float ondalıklı sayı
// string karakter dizisi char karakterdir
//
// int x = 5;
// char a = 'b';
// string b = "selam";
// double tets = 3.4;
// float se = 3;


// int x = 5;  4 byte 
// double y = 5.2; 8 byte  
// string name = "Mehmet"; 2x6 byte 
 
Console.WriteLine("2 Sayi girin toplayalim");
int sayi1 = Convert.ToInt32(Console.ReadLine());
int sayi2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(sayi1 + sayi2);