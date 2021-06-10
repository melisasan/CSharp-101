using System;

namespace Inheritance
{
    public class Hayvanlar : Canlilar
    {
        protected void Adaptasyon()
        {
            Console.WriteLine("Hayvanlar adaptasyon kurabilir");
        }
 
        //override virtual method
        public override void UyaranlaraTepki()
        {
            base.UyaranlaraTepki();
            Console.WriteLine("Hayvanlar temasa tepki verir.");
        }
    }

    public class Surungenler : Hayvanlar
    {
        public Surungenler()
        {
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();

        }
        public void SurunerekHareketEderler()
        {
            Console.WriteLine("Sürüngenler sürünerek hareket ederler");
        }
    }
    public class Kuslar : Hayvanlar
    {
        public Kuslar()
        {
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
            base.UyaranlaraTepki();

        }
        public void Ucmak()
        {
            Console.WriteLine("Kuslar uçar");
        }
    }
}