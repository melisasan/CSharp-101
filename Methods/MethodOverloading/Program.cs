using System;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //out parametreler
            string sayi = "2432";

            //sayıyı çevirip çevirmediğine bak ve çevirebiliyorsan sonucunda bu sayı şu şekilde geri dönsün
            bool sonuc = int.TryParse(sayi, out int outSayi);
            if (sonuc)
            {
                Console.WriteLine("Başarılı");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("Başarısız");
            }

            Metodlar metodlar = new Metodlar();
            metodlar.Toplama(8,3,out int toplamSonuc);
            Console.WriteLine(toplamSonuc);

            //method overloading 
            int i = 213;
            metodlar.EkranaYazdir(i);

            metodlar.EkranaYazdir("C","#");
            //metod imzası
            //metodAdı + parametre sayisi + parametre
            

        }
    }

    class Metodlar
    {
        public void Toplama(int a,int b,out int toplam)
        {
           toplam = a+b;
        }

        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }
         public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }
        public void EkranaYazdir(string veri1,string veri2)
        {
            Console.WriteLine(veri1+veri2);
        }
    }
}
