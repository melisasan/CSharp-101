using System;

namespace Exercise2
{
    //Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif 
    //sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen kaç adet pozitif sayı girileceğini yazın: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Kaç ile tam bölünen yada ona eşit olan sayılar gösterilsin ? ");
            int m = int.Parse(Console.ReadLine());

            int[] dizi = new int[n];
            
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Lütfen {0}. elemanı girin ",i+1);
                dizi[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Girilen sayılardan {0} ile tam bölünen ya da eşit olanlar ",m);
            foreach (var item in dizi)
            {
                if(item % m == 0 || item == m)
                Console.WriteLine(item);
            }

        }
    }
}
