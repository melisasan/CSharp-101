using System;

namespace Exercise4
{
    class Program
    {
        //Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir cümle yazın: ");
            string sentece = Console.ReadLine();

            string[] word = sentece.Split(" ");
    

            int kelime = word.Length;
             Console.WriteLine("Kelime sayısı: " + kelime);
            
            int harf = 0;
            char[] trim = {'!','.',',',';'};
            foreach (var item in word)
            {
                string res = item.Trim(trim);
                harf += res.Length;
            }
            Console.WriteLine("Harf sayısı: " + harf);

        }

    }

}
