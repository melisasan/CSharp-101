using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Bir sayı giriniz");
           int sayac = int.Parse(Console.ReadLine());
        
           //1den başlayarak girilen sayıya kadar olan tek sayıları yazdır
            for (int i = 0; i < sayac; i++)
            {
                if(i % 2 == 1)
                Console.WriteLine(i);
            }

            //1 ile 1000 arasındaki tek ve çift sayıların kendi içlerinde toplamlarını ekrana yazdırır.
            int tekToplam = 0;
            int ciftToplam = 0;
            for (int i = 0; i < 1000; i++)
            {
                if(i%2 == 1)
                    tekToplam += i; //tekToplam = tekToplam + i;

                else
                    ciftToplam += i;
            }
            Console.WriteLine("Tek Toplam = " + tekToplam);
            Console.WriteLine("Tek Toplam = " + ciftToplam);

            //break, continue

            //returns 1,2,3
            for (int i = 1; i < 7; i++)
            {
                if(i == 4)
                break;
                Console.WriteLine("i =" + i);
            }

            //returns 1,2,3,5,6
            for (int i = 1; i < 7; i++)
            {
                if(i == 4)
                continue;
                Console.WriteLine("i2 =" + i);
            }

        }
        
    }
}
