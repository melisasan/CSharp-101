using System;

namespace Exercise3
{
    //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan 
    //n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen kaç adet kelime girileceğini yazın: ");
            int n = int.Parse(Console.ReadLine());

            string[] words = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Lütfen {0}. kelimeyi girin: ",i+1);
                words[i] = Console.ReadLine();

            }
            Array.Reverse(words);
 
            Console.WriteLine("Sondan başa doğru giriş yaptığınız kelimeler: ");
            foreach (var item in words)
            {
                
                Console.WriteLine(item);
            }
        }
    }
}
