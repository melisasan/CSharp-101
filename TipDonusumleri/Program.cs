using System;

namespace TipDonusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //implicit conversion

            short a = 4; 
            ushort b = 3;
            byte c = 2; 

            
            int d = a+b+c;
            Console.WriteLine("d = " + d);

            long e = d;
            Console.WriteLine("e = " + e);
            
            float f = d;
            Console.WriteLine("f = " + f);

            string g = "csharp";
            char h = 'h';
            object o = g+h+f;
            Console.WriteLine("o = " + o);


            //explicit conversion

            float f1 = 7.10f;
            byte b1 = (byte)f1;
            Console.WriteLine("f1 = " + f1);

            double d1 = 2.5;
            float f2 = (float)d1;
            Console.WriteLine("f2 = " + f2);

            long l1 = 1234667;
            int i1 = (int)l1;
            Console.WriteLine("i1 = " + i1);

            //ToString method
            int i2 = 13;
            string str = i2.ToString();
            Console.WriteLine("str = "+ str);

            string str2 = 18.6f.ToString();
            Console.WriteLine("s2 = " + str2);

            //System.convert
            string str3 = "10";
            int sayi = Convert.ToInt32(str3);

            //parse
            string str4 = "21";
            string str5 = "15.5";
            int i3;
            double d2;

            i3 = Int32.Parse(str4);
            d2 = Double.Parse(str5);

            Console.WriteLine("i3 = " + i3 +" d2 = " + d2);
            







        
        }
    }
}
