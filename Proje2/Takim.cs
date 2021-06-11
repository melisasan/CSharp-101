using System;
using System.Collections.Generic;

namespace Proje2
{
    public class Takim
    {
        private int id;

        private string ad;

        public Takim(int id, string ad = null)
        {
            this.id = id;
            this.ad = ad;
        }


        public int Id { get => id; set => id = value; }

        public string Ad { get => ad; set => ad = value; }

    }

    public static class TakimManager {
        public static List<Takim> TakimList ;

        static TakimManager()
        {
            TakimList = DefaultTakim();
        }

        public static List<Takim> DefaultTakim()
        {
            return new List<Takim>()
            {
                new Takim(1,"Canan Yıldırım"),
                new Takim(2,"Arzu Bardakçı"),
                new Takim(1,"Zekiye Şener"),
                new Takim(2,"Yiğit Ai Türk"),
                new Takim(1,"Sena Kurt"),
                new Takim(2,"Beyza Topaloğlu"),


            };
        }
        
    }
}