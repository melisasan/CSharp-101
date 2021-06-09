using System;
using System.Collections.Generic;

namespace DictionaryCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            // System.Collections.Generic
            //Dictionary<key,value>
            Dictionary<int,string> kullanicilar = new Dictionary<int, string>();

            kullanicilar.Add(10,"Melisa San");
            kullanicilar.Add(15,"Serkan Altuntaş");
            kullanicilar.Add(19,"Oğuzhan Kubilay Güzel");
            kullanicilar.Add(24,"Barış Dilber");


            //Dizinin elemanlarına erişim
            Console.WriteLine("************Elemanlara Erişim*********");
            Console.WriteLine(kullanicilar[10]);

            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item);
            }

            //Count
            Console.WriteLine("Count: " + kullanicilar.Count);

            //Contains
            Console.WriteLine("Contains Key: " + kullanicilar.ContainsKey(15)); //returns true
            Console.WriteLine("Contains Value: " + kullanicilar.ContainsValue("Serkan Altuntaş")); //returns true

            //Remove
            kullanicilar.Remove(19);
            Console.WriteLine("Removed Dictionary");
            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item.Value);
            }


            //Keys
            Console.WriteLine("**********Keys***********");

            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item.Key);
            }



            
        



        }
    }
}
