using System;

namespace AbstractClass
{
    public class NewCivic : Otomobil
    {
        public override Marka HangiMarkanınAracı()
        {
            return Marka.Honda;
        }

        public override Renk StandartRengiNe()
        {
            return Renk.Gri;
        }
    }




}