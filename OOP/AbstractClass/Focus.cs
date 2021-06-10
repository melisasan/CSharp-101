using System;

namespace AbstractClass
{
    public class Focus : IOtomobil
    {
        public int KacTekerlektenOlusur()
        {
            return 4;
        }

        public Marka HangiMarkanınAracı()
        {
            return Marka.Ford;
        }

        public Renk StandartRengiNe()
        {
            return Renk.Beyaz;
        }
    }
}