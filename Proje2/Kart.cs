using System;

namespace Proje2
{
    class Kart{
        public string Baslik;
        public string Icerik;
        public int KisiId;
        public Buyukluk EnumBuyuk;


        public Kart()
        {

        }

        public Kart(string baslik, string ıcerik, int kisiId, Buyukluk enumBuyuk)
        {
            Baslik = baslik;
            Icerik = ıcerik;
            KisiId = kisiId;
            EnumBuyuk = enumBuyuk;
        }
    }

    enum Buyukluk
    {
        XS = 1,
        S,
        M,
        L,
        XL
    }
}