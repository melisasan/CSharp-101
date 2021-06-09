using System;
using System.Collections.Generic;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T> class
            //System.Collections.Generic

            //T ->Generic olduğunu söylüyor. object türündedir ve bir nesne alabilir.
            //Listenin içerisindeki nesnelerin tipini ifade ediyor

            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(35);
            sayiListesi.Add(453);
            sayiListesi.Add(57);
            sayiListesi.Add(5);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("sarı");
            renkListesi.Add("yeşil");
            renkListesi.Add("mor");
            renkListesi.Add("eflatun");
            renkListesi.Add("siyah");
            renkListesi.Add("turkuaz");

            //Count
            Console.WriteLine("Renk listesi eleman sayısı: ", + renkListesi.Count);

            foreach (var sayi in sayiListesi)
            {
                Console.WriteLine(sayi);
            }
            
            //foreach yazımı
            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));

            renkListesi.Remove("mor");
            renkListesi.RemoveAt(2);


            renkListesi.ForEach(renk => Console.WriteLine(renk));
            
            //liste içerisinde arama
            if (sayiListesi.Contains(35))
            {
                Console.WriteLine("35 liste içerisinde bulundu");
            }

            //Eleman ile index e erişme
            Console.WriteLine("Sarı'nın liste içerisindeki index değeri: "+ renkListesi.BinarySearch("sarı"));

            //Diziyi List'e çevirme

            string[] diller = {"C","Java","Python","C#"};

            List<string> dilListesi = new List<string>(diller);

            //Listeyi temizleme
            dilListesi.Clear();

            //List içerisinde nesne tutmak
            List<Kullanıcılar> kullanıcılars = new List<Kullanıcılar>();

            Kullanıcılar kullanıcı1 = new Kullanıcılar();
            kullanıcı1.Isim = "Tom";
            kullanıcı1.Soyisim = "Hanks";
            kullanıcı1.Yas = 51;

            Kullanıcılar kullanıcı2 = new Kullanıcılar();
            kullanıcı2.Isim = "Anna";
            kullanıcı2.Soyisim = "Berry";
            kullanıcı2.Yas = 38;
            
            kullanıcılars.Add(kullanıcı1);
            kullanıcılars.Add(kullanıcı2);

            List<Kullanıcılar> kullanıcılars2 = new List<Kullanıcılar>();
            kullanıcılars2.Add(new Kullanıcılar()
            {
                Isim = "Frank",
                Soyisim = "Green",
                Yas= 21
            });

            foreach (Kullanıcılar kullanıcı in kullanıcılars)
            {
                Console.WriteLine("Kullanıcı Adı: " +kullanıcı.Isim);
                Console.WriteLine("Kullanıcı Soyadı: " +kullanıcı.Soyisim);
                Console.WriteLine("Kullanıcı Yaş: " +kullanıcı.Yas);

            }

        }
    }
    public class Kullanıcılar{
        private string isim;
        private string soyisim;
        private int yas;

        //encapsulate fields
        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}
