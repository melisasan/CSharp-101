using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            TohumluBitkiler tohumluBitkiler = new TohumluBitkiler();
            // tohumluBitkiler.Beslenme();
            // tohumluBitkiler.Bosaltim();
            // tohumluBitkiler.Fotosentez();
            // tohumluBitkiler.Solunum();
            tohumluBitkiler.TohumlaCogalma();

            Console.WriteLine("***************************");
            
            Kuslar kirlangic = new Kuslar();
            // kirlangic.Solunum();
            kirlangic.Ucmak();
            // kirlangic.Adaptasyon();
            // kirlangic.Bosaltim();
            // kirlangic.Beslenme();

        }
    }
}
