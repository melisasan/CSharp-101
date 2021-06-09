using System;

namespace Exercise1
{
    //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
    //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.


    class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("Lütfen kaç adet pozitif sayı girileceğini girin: ");
            int n = int.Parse(Console.ReadLine());

            int[] dizi = new int[n];
            
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Lütfen {0}. elemanı girin ",i+1);
                dizi[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Girilen çift sayılar: ");
            foreach (var item in dizi)
            {
                if(item % 2 == 0)
                Console.WriteLine(item);
            }

          
        }
    }
}