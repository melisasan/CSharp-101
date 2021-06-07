using System;

namespace Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Atama ve işlemli atama
            int a = 4;
            int b = 5;

            //a = a+2 
            a +=2;

            //b = b+2
            b +=2;

            //Mantıksal operatörler -> ||,&&,!

            bool isSuccess = true;
            bool isCompleted = false;


            if(isSuccess && isCompleted)
                 Console.WriteLine("Perfect!");
            
            if(isSuccess || isCompleted)
                Console.WriteLine("Great");

            if(isSuccess && !isCompleted)
                Console.WriteLine("Fine");

            //İlişkisel Operatörler  -> <,>,<=,>=,==,!=

            int x = 1;
            int y = 7;
            bool result = x<y;

            Console.WriteLine("Is x smaller than y ? " + result);
            result = x>y;
            Console.WriteLine("Is x greater than y ? " + result);
            result = x>=y;
            Console.WriteLine("Is x greater than or equal to y ? " + result);
            result = x==y;
            Console.WriteLine("Is x equal to y ? " + result);
            result = x!=y;
            Console.WriteLine("Is x is not equal to y ? " + result);

            //Aritmetik Operatörler -> /,-,+,*

            int num1 = 6;
            int num2 = 8;
            int res = num1 * num2;

            Console.WriteLine(num1 + " * "+ num2 + "is = " + res);

            res = num1++;
            Console.WriteLine(" num1++ is = " + res);

            // % mod almak için kullanılır

            int res2 = 30%4;
            Console.WriteLine("30 mod 4 is = " + res2);















        }
    }
}
