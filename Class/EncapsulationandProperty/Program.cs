using System;

namespace EncapsulationandProperty
{
    class Program
    {
        static void Main(string[] args)
        {
           Ogrenci ogr1 = new Ogrenci("Miray","Yıldırım",2017342812,3);
           ogr1.SinifAtlat();
           ogr1.BilgileriGetir();

           Ogrenci ogr2 = new Ogrenci("Baran","Ata",2017462681,1);
           ogr2.BilgileriGetir();
           ogr2.SinifDusur();
           ogr2.SinifDusur();
           ogr2.BilgileriGetir();
           
        }
    }

    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int no;
        private int sinif;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int No { get => no; set => no = value; }
        public int Sinif 
        {
             get => sinif; 
             set 
             {
                 if(value < 1){
                     Console.WriteLine("Sınıf en az 1 olabilir");
                     sinif = 1;
                 }
                 else
                   sinif = value;
               
             } 
       }

        // get { return isim; }
        // set { isim = value; }

         public Ogrenci()
        {
            
        }
        public Ogrenci(string ısim, string soyisim, int no, int sinif)
        {
            Isim = ısim;
            Soyisim = soyisim;
            No = no;
            Sinif = sinif;
        }

        public void BilgileriGetir(){
            Console.WriteLine("Öğrenci Bilgileri: ");
            Console.WriteLine("Öğrenci adı: {0}",this.Isim);
            Console.WriteLine("Öğrenci adı: {0}",this.Soyisim);
            Console.WriteLine("Öğrenci adı: {0}",this.No);
            Console.WriteLine("Öğrenci adı: {0}",this.Sinif);

        }

        public void SinifAtlat()
        {
            this.Sinif = this.Sinif + 1;
        }

         public void SinifDusur()
        {
            this.Sinif = this.Sinif - 1;
        }

       
    }
    
}
