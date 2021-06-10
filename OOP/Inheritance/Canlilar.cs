using System;

namespace Inheritance
{
    public class Canlilar
    {
        protected void Beslenme()
        {
            Console.WriteLine("Canlılar beslenir");
        }
        protected void Solunum()
        {
            Console.WriteLine("Canlılar Solunum yapar");
        }
        protected void Bosaltim()
        {
            Console.WriteLine("Canlılar boşaltım yapar");
        }

        //POLYMORPHISM
        public virtual void UyaranlaraTepki()
        {
            Console.WriteLine("Canlılar uyaranlara tepki verir");
        }
        
    }
}