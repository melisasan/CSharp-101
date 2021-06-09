using System;

namespace Inheritance
{
    public class Hayvanlar : Canlilar
    {
        protected void Adaptasyon()
        {
            Console.WriteLine("Hayvanlar adaptasyon kurabilir");
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

        }
        public void Ucmak()
        {
            Console.WriteLine("Kuslar uçar");
        }
    }
}