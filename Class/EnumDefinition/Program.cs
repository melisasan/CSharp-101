using System;

namespace EnumDefinition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Cumartesi); //numerik değerine erişir

            Console.WriteLine("Lütfen hava durumunu giriniz: ");
            int derece = int.Parse(Console.ReadLine());

            if(derece <= (int)HavaDurumu.Normal && derece >= (int)HavaDurumu.Soguk)
               Console.WriteLine("Hava durumu normalin altında");
            else if (derece < (int)HavaDurumu.Soguk)
               Console.WriteLine("Hava durumu soguk");
            else if (derece >= (int)HavaDurumu.Sıcak)
               Console.WriteLine("Hava durumu sıcak");
            else if(derece >= (int)HavaDurumu.Normal && derece < (int)HavaDurumu.Sıcak)
               Console.WriteLine("Hava durumu ılık");
            else
               Console.WriteLine("Hava durumu çok sıcak");
           
        }
    }
     enum Gunler
     {
        Pazartesi = 1,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma,
        Cumartesi,
        Pazar
     }
     enum HavaDurumu
     {
        Soguk = 5,
        Normal = 20,
        Sıcak = 25,
        CokSıcak = 30
     }
}
