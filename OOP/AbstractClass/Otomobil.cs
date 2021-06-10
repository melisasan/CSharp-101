using System;

namespace AbstractClass 
{
    public abstract class Otomobil
    {
        public int KacTekerlektenOlusur()
        {
            return 4;
        }

        //default olarak tanımlanır ama başka yerden ezilmesine izin verir
        public virtual Renk StandartRengiNe()
        {
            return Renk.Beyaz;
        }

        //bütün arabalarda farklı sonuç döner
        //her birinde bu metod çağırılmalıdır bu yüzden abstract metod olarak yazarız
        //alt sınıfları bu metodu implemente etmeye zorlamış oluruz

        public abstract Marka HangiMarkanınAracı();
      
    }
}