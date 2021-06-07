using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //Integera çevirelemeyen bir değer girildiğinde hata fırlatır
            try
            {
            Console.WriteLine("1 ile 100 arasında bir sayı girin");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girilen sayı = " + num);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            //Her durumda çalışacak olan blok
            finally
            {
                Console.WriteLine("İşlem tamamlandı");
            }
           
           //Argument Null Exception
            try
            {
                
                int number = int.Parse(null);
            }
            catch (ArgumentNullException ex)
            {
                
                Console.WriteLine("Boş bir değer girdiniz");
                Console.WriteLine("HATA: " + ex);
            }

            //Format Exception
            try
            {
                
                int a = int.Parse("Hello Worl!");
            }
            catch (FormatException ex)
            {
                
                Console.WriteLine("Girilen string uygun  formatta değil");
                Console.WriteLine("HATA: " + ex);
            }

            //Overflow Exception 
            //integer kapsamı dışında girilen değerlerde exception fırlatılır
            try
            {
                
                int b = int.Parse("-20000000000");
            }
            catch (OverflowException ex)
            {
                
                Console.WriteLine("Çok küçük/büyük bir değer girdiniz");
                Console.WriteLine("HATA: " + ex);
            }









        }
    }
}
