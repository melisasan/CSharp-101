using System;

namespace AbstractClass
{
    public class Civic : IOtomobil
    {
        public int KacTekerlektenOlusur()
        {
            return 4;
        }

        public Marka HangiMarkanınAracı()
        {
            return Marka.Honda;
        }

        public Renk StandartRengiNe()
        {
            return Renk.Gri;
        }
    }
}