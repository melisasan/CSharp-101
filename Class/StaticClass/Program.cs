using System;

namespace StaticClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan sayısı: {0} ", Calisan.CalisanSayisi);
            //Çalışan sınıfından ilk nesne türetildiğinde ilk olarak static constructor çalışır 
            //fakat bir üstteki kodda static constructor çalıştığı için nesne üretilince tekrar 
            //çalışmasına gerek kalmadı.
            Calisan calisan = new Calisan("Melis","Yılmaz","IK");
            Console.WriteLine("Çalışan sayısı: {0} ", Calisan.CalisanSayisi);

            //static sınıflara erişme
            Console.WriteLine("Toplama işlemi sonucu: {0}" + Islemler.Topla(100,20));
            Console.WriteLine("Çıkarma işlemi sonucu: {0}" + Islemler.Cıkar(100,20));
            
        }
    }

    class Calisan
    {
        //bu property'e sınıf aracılığıyla erişilir.
        private static int calisanSayisi;
        private string isim ;
        private string soyisim;
        private string departman;

        public static int CalisanSayisi { get => calisanSayisi; }

        static Calisan()
        {
            calisanSayisi = 0;
        }
        public Calisan(string isim, string soyisim, string departman)
        {
            this.isim = isim;
            this.soyisim = soyisim;
            this.departman = departman;
            calisanSayisi ++;
        }
    }

    //static classlardaki tüm elemanlar static olmak zorunda.
    static class Islemler
    {
        public static long Topla(int sayi1,int sayi2)
        {
            return sayi1+sayi2;
        }
         public static long Cıkar(int sayi1,int sayi2)
        {
            return sayi1-sayi2;
        }
    }
}
