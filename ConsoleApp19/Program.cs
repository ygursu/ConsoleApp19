﻿
int tahmin, hak = 5;
bool durum = false;
Random rastgele = new Random();
int rastgeleSayi = rastgele.Next(0, 10);
for (int kalanHak = hak; kalanHak > 0; kalanHak--)
{
    Console.WriteLine("Hak {0}", kalanHak);
    Console.Write("Tahmininiz :");
    tahmin = int.Parse(Console.ReadLine());
    if (tahmin == rastgeleSayi)
    {
        Console.WriteLine("Tebrikler");
        durum = true;
        break;
    }
    else if (rastgeleSayi > tahmin && kalanHak != 1)
        Console.WriteLine("Daha büyük bir sayı girin");
    else if (rastgeleSayi < tahmin && kalanHak != 1)
        Console.WriteLine("Daha küçük bir sayı girin");
}
if (!durum)
{
    Console.WriteLine("Tekrar Deneyin!");
    Console.WriteLine("Sayı : {0}", rastgeleSayi);
}
Console.
