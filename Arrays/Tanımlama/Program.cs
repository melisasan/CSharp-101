using System;

namespace Tanımlama
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dizi tanımlama
            string[]  meyveler  = new string[5];

            string[] gunler = {"pazartesi","salı","çarşamba","perşembe","cuma","cumartesi","pazar"};

            int[] sayilar;

            sayilar = new int[5];

            //Dizilere değer atama 

            meyveler[0] = "elma";
            sayilar[3] = 5;

            Console.WriteLine("Haftanın ikinci günü: ",gunler[1]);
            Console.WriteLine(sayilar[3]);
            Console.WriteLine(meyveler[0]);

            //Döngülerle dizi kullanımı 
            //klavyeden girilen n tane sayının ortalamasını alan program

            Console.WriteLine("Lütfen dizinin eleman sayısını girin:");
            int boyut = int.Parse(Console.ReadLine());

            int[] degerler = new int[boyut];

           for (int i = 0; i < boyut; i++)
           {
               Console.WriteLine("Lütfen dizinin {0}. elemaını girin:", i+1);
               degerler[i] = int.Parse(Console.ReadLine());
           }

            int toplam = 0;
            foreach (var item in degerler)
            {
                toplam += item;

            }
            
            float sonuc = toplam/boyut;
            Console.WriteLine("Girilen sayıların ortalaması : " +sonuc);



        }
    }
}
