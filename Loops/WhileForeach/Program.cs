using System;

namespace WhileForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            //while
            //1 den başlayarak console'dan girilen sayıya kadar ortalama hesaplama
            Console.WriteLine("Lütfen bir sayı giriniz:");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;

            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac ++;
            }

            Console.WriteLine(toplam/sayi);

            // 'a' dan 'z' ye kadar tüm harfleri console'a yazdır.

            char ch = 'a';
            while (ch <= 'z')
            {
                Console.WriteLine(ch);
                ch++;
            }

            Console.WriteLine("-----Foreach-----");
            string[] arabalar = {"BMV","Ford","Toyota","Nissan"};

            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }






        }
    }
}
