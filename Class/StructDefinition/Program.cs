using System;

namespace StructDefinition
{
    class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen dikdortgen = new Dikdortgen();
            dikdortgen.kisa = 4;
            dikdortgen.uzun = 10;
            Console.WriteLine("Class alan hesabı: {0}", dikdortgen.Alan());

            Dikdortgen_Struct dikdortgen_Struct = new Dikdortgen_Struct(3,4);
           Console.WriteLine("Struct alan hesabı: {0}", dikdortgen_Struct.Alan());


            //struct yaratma
            Dikdortgen_Struct d_struct;
            d_struct.kisa = 67;
            d_struct.uzun = 321;
            Console.WriteLine("Struct alan hesabı: {0}", d_struct.Alan());


        }
    }

    class Dikdortgen
    {
        public int kisa;
        public int uzun;

        public Dikdortgen()
        {
           kisa= 5;
           uzun = 9;
        }
        public long Alan()
        {
            return this.kisa * this.uzun;
        }
    }

    struct Dikdortgen_Struct
    {
         public int kisa;
        public int uzun;

        // structta olmaz!
        // public Dikdortgen()
        // {
        //    kisa= 5;
        //    uzun = 9;
        // }

        public Dikdortgen_Struct(int kisa, int uzun)
        {
            this.kisa = kisa;
            this.uzun = uzun;
        }

        public long Alan()
        {
            return this.kisa * this.uzun;
        }
    }
}
