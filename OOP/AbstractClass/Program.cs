using System;

namespace AbstractClass
{
    class Program
    {
        
        static void Main(string[] args)
        {

            
           Focus focus = new Focus();
           Console.WriteLine(focus.HangiMarkanınAracı().ToString());
            Console.WriteLine(focus.KacTekerlektenOlusur().ToString());
           Console.WriteLine(focus.StandartRengiNe().ToString());

           Console.WriteLine("-------------------------------------------");
           Civic civic = new Civic();
           Console.WriteLine(civic.HangiMarkanınAracı().ToString());
            Console.WriteLine(civic.KacTekerlektenOlusur().ToString());
           Console.WriteLine(civic.StandartRengiNe().ToString());

           Console.WriteLine("-------------------------------------------");
           NewFocus newfocus = new NewFocus();
           Console.WriteLine(newfocus.HangiMarkanınAracı().ToString());
            Console.WriteLine(newfocus.KacTekerlektenOlusur().ToString());
           Console.WriteLine(newfocus.StandartRengiNe().ToString());

            Console.WriteLine("-------------------------------------------");
           NewCivic newcivic = new NewCivic();
           Console.WriteLine(newcivic.HangiMarkanınAracı().ToString());
            Console.WriteLine(newcivic.KacTekerlektenOlusur().ToString());
           Console.WriteLine(newcivic.StandartRengiNe().ToString());


        }
    }
    public enum Marka{
        Ford = 1,
        Honda,
        Toyota
    }

    public enum  Renk
    { 
      Gri = 1,
      Beyaz  
    }
}
