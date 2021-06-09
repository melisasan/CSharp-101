using System;
using System.Collections;
using System.Collections.Generic;


namespace Arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
             //System.Collections namespace

            ArrayList list = new ArrayList();
            list.Add("Ayşe");
            list.Add(8);
            list.Add(false);
            list.Add('M');

            //içerisindeki verilere erişim
            Console.WriteLine("Listenin 2. index'i: " +list[2]);

            foreach (var item in list)
                Console.WriteLine(item);

            //AddRange
            Console.WriteLine("*********AddRange************");
            string[] yemekler = {"hamburger","pizza","dolma","kebap"};
            List<int> sayilar = new List<int>(){3,2,45,8675,32};

            ArrayList list2 = new ArrayList();

            list.AddRange(yemekler);
            list.AddRange(sayilar);
            list2.AddRange(sayilar);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //Sort 
            Console.WriteLine("*******Sort*******");
            //list.Sort(); ->  compile time da hata vermezken runtime da verir
            list2.Sort();

            foreach(var item in list2)
               Console.WriteLine(item);

            //Binary search
            Console.WriteLine("*******Binary Search*******");
            Console.WriteLine(list2.BinarySearch(8675));


            //Reverse
            Console.WriteLine("*******Reverse*******");
            list2.Reverse();

            foreach (var item in list2)
            {
                Console.WriteLine(item);

            }

            //Clear
            Console.WriteLine("*******Clear*******");
            list2.Clear();

            foreach (var item in list2)
            {
               Console.WriteLine(item); 
            }



            







        }
    }
}
