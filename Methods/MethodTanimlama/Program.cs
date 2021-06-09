using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //erisim_belirtici geri_donustipi metot_adi(parametreListesi/arguman)
            //{
                ///komutlar;
            ///}
            
            int a = 12;
            int b = 5;

           Console.WriteLine("a+b: "+ (a+b));
           
            int sonuc = Topla(a,b);

            Metotlar metotlar = new Metotlar();
            metotlar.EkranaYazdir(Convert.ToString(sonuc));

            int sonuc2 = metotlar.ArttirVeTopla(a,b);
            metotlar.EkranaYazdir(sonuc2.ToString());
            metotlar.EkranaYazdir((a+b).ToString());

           int sonuc3 = metotlar.RefArttirTopla(ref a,ref b);
           metotlar.EkranaYazdir(sonuc3.ToString());
           metotlar.EkranaYazdir((a+b).ToString());

        }

        static int Topla(int x,int y)
        {
            return x+y;

        }
    }

    class Metotlar
    {
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine("Ekrana yazdırılan veri: " + veri);
        }

        public int ArttirVeTopla(int deger1, int deger2)
        {  
           Console.WriteLine("ArttırveTopla metodu");
           deger1 += 1; 
           deger2 += 1;
           return deger1 + deger2;
        }

        public int RefArttirTopla(ref int deger1, ref int deger2)
        {
           Console.WriteLine("RefArttırTopla metodu");
           deger1 += 1;
           deger2 += 1;
           return deger1 + deger2;
        }
    }
}
