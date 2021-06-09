using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********Calisan 1************");
           Calisan calisan1 = new Calisan();
            calisan1.Ad = "Eda";
            calisan1.Soyad = "Kaya";
            calisan1.No = 24690234;
            calisan1.Departman = "Bilgi İşlem";

            calisan1.BilgileriGetir();

            Console.WriteLine("**********Calisan 2************");
            Calisan calisan2 = new Calisan("Derya","Demir",34574268,"İnsan Kaynakları");
            calisan2.BilgileriGetir();

            Console.WriteLine("**********Calisan 3************");
            Calisan calisan3 = new Calisan("Taha","Ölmez");
            calisan3.BilgileriGetir();


        }
    }
    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public Calisan()
        {

        }
        public Calisan(string ad,string soyad,int no,string departman)
        {
           this.Ad = ad;
           //Ad = ad;
           this.Soyad = soyad;
           this.No = no;
           this.Departman = departman;
        }

        //overloading
         public Calisan(string ad,string soyad)
        {
           this.Ad = ad;
           //Ad = ad;
           this.Soyad = soyad;
        }

        public void BilgileriGetir(){
            
            Console.WriteLine("Çalışan Adı:{0}",Ad);
            Console.WriteLine("Çalışan Soyadı:{0}",Soyad);
            Console.WriteLine("Çalışan Numarası:{0}",No);
            Console.WriteLine("Çalışan Departmanı:{0}",Departman);
        }
    }
}
