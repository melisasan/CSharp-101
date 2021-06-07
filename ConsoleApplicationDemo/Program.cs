using System;

namespace ConsoleApplicationDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Isminizi girniz");
            string name = Console.ReadLine();
            Console.WriteLine("Soyadınızı girniz");
            string surname = Console.ReadLine();
            Console.WriteLine("Isminiz : " + name +"Soyisminiz" + surname);

        }
    }
}
