using System;

namespace Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int deger = 3; //4 byte
            uint ui; //4byte

            Int16 i16; //2 byte
            Int32 i32; //4 byte
            Int64 i64; //8 byte

            //stringe null atama yapılabilir
            string a = null; 

            //değişken isimleri '_' kullanılarak iki kelime olarak yazılabilir.
            string my_value = null;

            byte b; // 1byte

            short s; // 2byte
            ushort us; //2byte

            long l; //8 byte
            ulong ul; //8byte

            float f; //4byte
            double d;//8 byte
            decimal de; //16 byte

            char ch = '2'; //2byte
            string str = "Melisa"; //sınısız

            bool bt = true;
            bool bf = false;

            DateTime dt = DateTime.Now;

            Console.WriteLine(dt);


           //string ile işlemler
            string st = string.Empty;
             
            //integer tanımlama şekilleri

            int a1 = 5;
            int a2 = 3;
            int a3 = a1 * a2;

            //boolean

            bool bo = 10>2;

            //Değişken dönüşümleri

            int i1 = 11;
            string s1 = "11";

            string s2 = s1 + i1.ToString();
            Console.WriteLine(s2); //Çıktı = 1111

            int i2 = Convert.ToInt32(s1);
            Console.WriteLine(s1); //Çıktı =11

           //datetime
           string datetime = DateTime.Now.ToString("dd/MM/yyyy");
           Console.WriteLine(datetime);

           string date = DateTime.Now.ToShortDateString();
           Console.WriteLine(date);

           string time = DateTime.Now.ToString("HH/mm");
           Console.WriteLine(time);

           string datetime2 = DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss");
           Console.WriteLine(datetime2);

           












        }
    }
}
