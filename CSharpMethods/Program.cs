using System;

namespace CSharpMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "C# 101 patikası String Metodları";
            string b = "Dersimiz C#";
            string c= "C#";

            //Length;
            Console.WriteLine(a.Length);

            //ToUpper, ToLower
            Console.WriteLine(a.ToUpper());
            Console.WriteLine(a.ToLower());

            //Concat == birleşirme
            Console.WriteLine(String.Concat(a," Merhaba!"));

            //Compare, CompareTo

            Console.WriteLine(a.CompareTo(b)); // a==b ise 0, a >b ise 1, a < b ise -1 
            Console.WriteLine(String.Compare(a,b,true));//son parametre ignore casedir, true ise case sensetive

            //Contains
            Console.WriteLine(a.Contains(c));
            Console.WriteLine(a.EndsWith("Metodları"));
            Console.WriteLine(a.StartsWith("Merhaba!"));


            //IndexOf
            Console.WriteLine(a.IndexOf("C#")); //C# ı bulursa C'nin indexini döner, bulamazsa -1 döner

            //Insert 
            Console.WriteLine(a.Insert(0,"Dersimiz ")); //en başa ekleme yap
            Console.WriteLine(a.LastIndexOf("a")); //Birden fazla a vardır. a'nın bulunduğu son indexi getirir.

            //PadLeft, PadRight
            Console.WriteLine(a + b.PadLeft(20)); //b nin soluna 20 ye tamamlayacak kadar boşluk ekler.
            //değişken sayısı + boşluk sayısı 20 olacaktır
            
            Console.WriteLine(a + b.PadLeft(20,'*'));
            Console.WriteLine(a.PadRight(50,'-')+ b);

            //remove
            Console.WriteLine(a.Remove(10)); //10. indexten başlayarak sonrasını siler
            Console.WriteLine(a.Remove(5,3)); 
            Console.WriteLine(a.Remove(0,1));

            //replace
            Console.WriteLine(b.Replace("C#","CSharp"));
            Console.WriteLine(b.Replace(" ","*"));

            //split
            Console.WriteLine(b.Split(' ')[1]); //stringi boşuklara göre parçala, diziye at ve 1. indexi getir

            //substring
            Console.WriteLine(b.Substring(4)); //4. indexten başlayarak sonuna kadar getir
            Console.WriteLine(b.Substring(4,2)); //4. indexten başlayarak 6 karakter getir





        }
    }
}
