using System;

namespace Proje1 
{
    public class Kisi
    {
        private string isim;
        private string soyisim;
        private string tel;

        public Kisi(string isim, string soyisim, string tel)
        {
            this.isim = isim;
            this.soyisim = soyisim;
            this.tel = tel;
        }

        public Kisi()
        {
            
        }
        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public string Tel { get => tel; set => tel = value; }
    }
}