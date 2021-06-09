using System;

namespace DateTimeMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now); //9.06.2021 18:35:15
            Console.WriteLine(DateTime.Now.Date); //9.06.2021 00:00:00
            Console.WriteLine(DateTime.Now.Day); //9
            Console.WriteLine(DateTime.Now.Month); //6
            Console.WriteLine(DateTime.Now.Year); //2021
            Console.WriteLine(DateTime.Now.Hour); //18
            Console.WriteLine(DateTime.Now.Minute); //35
            Console.WriteLine(DateTime.Now.Second); //15

            Console.WriteLine(DateTime.Now.DayOfWeek); //Wednesday
            Console.WriteLine(DateTime.Now.DayOfYear); //160

            Console.WriteLine(DateTime.Now.ToLongDateString()); //9 Haziran 2021 Çarşamba
            Console.WriteLine(DateTime.Now.ToShortDateString()); //9.06.2021
            Console.WriteLine(DateTime.Now.ToLongTimeString()); //18:38:42
            Console.WriteLine(DateTime.Now.ToShortTimeString()); //18:38

            //şuanki zamana eklemeler yapmak
            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddSeconds(30));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddYears(10));
            Console.WriteLine(DateTime.Now.AddMilliseconds(50));

            //Datetime Format
            Console.WriteLine(DateTime.Now.ToString("dd")); //9
            Console.WriteLine(DateTime.Now.ToString("ddd")); //Çar
            Console.WriteLine(DateTime.Now.ToString("dddd")); //Çarşamba

            Console.WriteLine(DateTime.Now.ToString("MM")); //06
            Console.WriteLine(DateTime.Now.ToString("MMM")); //Haz
            Console.WriteLine(DateTime.Now.ToString("MMMM")); //Haziran

            Console.WriteLine(DateTime.Now.ToString("yy")); //21
            Console.WriteLine(DateTime.Now.ToString("yyy")); //2021
         

            //math kütüphanesi
            Console.WriteLine(Math.Abs(-25)); //25
            Console.WriteLine(Math.Sin(10));
            Console.WriteLine(Math.Cos(10));
            Console.WriteLine(Math.Tan(70));

            Console.WriteLine(Math.Ceiling(22.5)); //en yakın bir büyük sayıya yuvarla
            Console.WriteLine(Math.Round(22.7));  //23
            Console.WriteLine(Math.Round(22.3));  //22
            Console.WriteLine(Math.Floor(22.5));  //en yakın bir küçük sayıya yuvarla

            Console.WriteLine(Math.Max(23,74));
            Console.WriteLine(Math.Min(23,74));

            Console.WriteLine(Math.Pow(2,4)); //2^4

            Console.WriteLine(Math.Sqrt(9)); //9^2

            Console.WriteLine(Math.Log(9)); //Log9 9 un e tabanındaki karşılığı

            Console.WriteLine(Math.Exp(3)); //e^3

            Console.WriteLine(Math.Log10(10)); //10 un logaritma 10 tabanındaki karşılığı

        }
    }
}
