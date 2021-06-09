using System;

namespace ClassDefinition
{
    class Program
    {
        static void Main(string[] args)
        {
            //Söz Dizimi
            //class SinifAdi
            //{
            //  [Erişim Belirleyici] [Veri Tipi] ÖzellikAdi;
            //  [Erişim Belirleyici] [Geri Dönüş Tipi] MethodAdi([Parametre Listesi])
            //  {
            //  Metot Komutları
            //  }
            //}

            //Erişim Belirleyici
            //public
            //private
            //internal
            //protected
            
            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Eda";
            calisan1.Soyad = "Kaya";
            calisan1.No = 24690234;
            calisan1.Departman = "Bilgi İşlem";

            calisan1.BilgileriGetir();

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Derya";
            calisan2.Soyad = "Demir";
            calisan2.No = 24685326;
            calisan2.Departman = "İnsan Kaynakları";

            calisan2.BilgileriGetir();

        }
    }
    class Calisan
    {
        //properties
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public void BilgileriGetir(){
            
            Console.WriteLine("Çalışan Adı:{0}",Ad);
            Console.WriteLine("Çalışan Soyadı:{0}",Soyad);
            Console.WriteLine("Çalışan Numarası:{0}",No);
            Console.WriteLine("Çalışan Departmanı:{0}",Departman);
        }
    }

}
