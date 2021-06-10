using System;

namespace AbstractClass
{
    public class Corolla : IOtomobil
    {
        public int KacTekerlektenOlusur()
        {
            return 4;
        }

        public Marka HangiMarkanınAracı()
        {
            return Marka.Toyota;
        }

        public Renk StandartRengiNe()
        {
            return Renk.Beyaz;
        }
    }
}