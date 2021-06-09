using System;

namespace ArrayMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //sort arrays
            int[] numbers = {43,57,2,68,98,6,15,29};
          
            Console.WriteLine("Unsorted Array");

            foreach (var item in numbers)
                Console.WriteLine(item);

            Console.WriteLine("Sorted Array");
            Array.Sort(numbers);

            foreach (var item in numbers)
               Console.WriteLine(item);


             //clear arrays

             Console.WriteLine("Clear Array");
             //clear 2 elements starts from 2nd indice 
             Array.Clear(numbers,2,2);
            
             foreach (var item in numbers)
                Console.WriteLine(item);

            //reverse arrays

            Console.WriteLine("Reverse Array");
            Array.Reverse(numbers);

            foreach (var item in numbers)
               Console.WriteLine(item);

            //indexof array
            Console.WriteLine("Array IndexOf");
            Console.WriteLine("Index Of 23: ",Array.IndexOf(numbers,23));

            //resize array

            Console.WriteLine("Resize Array");
            Array.Resize<int>(ref numbers,9);
            numbers[8] = 99;

            Console.WriteLine("New array will be: ");
            foreach (var item in numbers)
               Console.WriteLine(item);


            
        }

    }
}
