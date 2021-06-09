using System;

namespace RecursiveExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            //recursive
            //3^4
            int result = 1;
            for (int i = 1; i < 5; i++)
            {
                result = result * 3;
                
            }
            Console.WriteLine(" 3^4 not recursive",result);
            Islemler Islemler = new();
            Console.WriteLine(" 3^4 recursive "+Islemler.Exponential(3,4));

            //extension methods
            string expr = "C# 101 Patikası";
            bool res =expr.CheckSpaces();
            Console.WriteLine(res);
            if (res)
            {
                Console.WriteLine(expr.RemoveWhiteSpaces());
                
            }
            Console.WriteLine(expr.MakeUpperCase());
            Console.WriteLine(expr.MakeLowerCase());
            Console.WriteLine("First character of our string: " + expr.GetFirstChareacter());


            int[] array = {2,435,73,21,6,8,35};
            array.SortArray();
            array.Print();
            
            int number = 7;
            Console.WriteLine("Is number is even? " + number.IsEvenNumber());
            
        
        }
    }

    public class  Islemler{
        public int Exponential(int sayi,int us)
        {
            if(us < 2)
                return sayi;
            
           return Exponential(sayi,us-1)*sayi;
        }
        //Exponential(3,4)
        //Exponential(3,3)*3
        //Exponential(3,2)*3*3
        //Exponential(3,1)*3*3*3
        //3*3*3*3 = 3^4

    }
    public static class Extension{

     //extension metodlar this ifadesi ile kullanılır
      public static bool CheckSpaces(this string param){
        return param.Contains(" ");
      }

      public static string RemoveWhiteSpaces(this string param){
          string[] arr = param.Split(" ");
          return string.Join("",arr);
      }

      public static string MakeUpperCase(this string param){
          return param.ToUpper();
      }

      public static string MakeLowerCase(this string param){
          return param.ToLower();
      }

      public static int[] SortArray(this int[] array){
          Array.Sort(array);
          return array;
      }

      public static void Print(this int[] array){
          Console.WriteLine("Print array: ");
          foreach (var item in array)
          {
              Console.WriteLine(item);
          }
      }

      public static bool IsEvenNumber(this int param){
          return param % 2 == 0;
      }

      public static string GetFirstChareacter(this string param){

          return param.Substring(0,1);
      }

    }
}
