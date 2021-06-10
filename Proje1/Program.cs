using System;
using System.Collections.Generic;

namespace Proje1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ");
            Console.WriteLine(" *******************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek \n(2) Varolan Numarayı Silmek \n(3) Varolan Numarayı Güncelleme \n(4) Rehberi Listelemek \n(5) Rehberde Arama Yapmak");
            int choice = int.Parse(Console.ReadLine());
            
            List<Kisi> kisilist = new List<Kisi>();
            Kisi kisi1 = new Kisi("Ayşe","Güzel","05346325785");
            Kisi kisi2 = new Kisi("Seda","Arık","05346025782");
            Kisi kisi3 = new Kisi("Arda","Erçin","05458764512");


            kisilist.Add(kisi1);
            kisilist.Add(kisi2);
            kisilist.Add(kisi3);

            Metodlar metodlar = new Metodlar();  

        while(true)
        {
             string strReadKey = Console.ReadKey().KeyChar.ToString();
             int.TryParse(strReadKey, out choice);


            switch(choice)
            {
                case 1:
                    Console.WriteLine(" Lütfen isim giriniz             : ");
                    string isim = Console.ReadLine();
                    Console.WriteLine(" Lütfen soyisim giriniz          :");
                    string soyisim = Console.ReadLine();
                    Console.WriteLine(" Lütfen telefon giriniz          :");
                    string telefon = Console.ReadLine();

                    
                    Kisi kisi = new Kisi(isim,soyisim,telefon);
                    kisilist.Add(kisi);
                    
                break;
                case 2:
                    Console.WriteLine("  Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
                    string adsoyad = Console.ReadLine();

                    metodlar.KisiSil(adsoyad,kisilist);


                break;
                case 3:
                    Console.WriteLine(" Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
                    string adsoyad1 = Console.ReadLine();                    
                    foreach (var item in kisilist)
                    {
                        if (item.Isim == adsoyad1 || item.Soyisim == adsoyad1)
                        {
                            metodlar.KisiGuncelle(item);
                            break;
                        }
                        else{
                            Console.WriteLine(" Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.\n* Silmeyi sonlandırmak için : (1) \n* Yeniden denemek için      : (2)");
                            int num = int.Parse(Console.ReadLine());
                            metodlar.KisiBulunamadi(num);
                        }
                    }


                break;
                case 4:
                    metodlar.RehberiListele(kisilist);
                break;
                case 5:
                    Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.\n**********************************************");
                    Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)\nTelefon numarasına göre arama yapmak için: (2)");
                    int num1 = int.Parse(Console.ReadLine());

                    if(num1 == 1)
                    {
                       Console.WriteLine("Aramak istediğiniz ismi ve ya soyismi girin: ");
                       string adsoyad2 = Console.ReadLine();
                       metodlar.Arama(adsoyad2,kisilist);

                    }
                    else if(num1 == 2)
                    {
                       Console.WriteLine("Aramak istediğiniz telefon numarasını girin: ");
                       string telefon3 = Console.ReadLine();
                       metodlar.Arama(telefon3,kisilist);
                    }
                    else{
                        Console.WriteLine("Yalnızca 1 ya da 2 girebilirizsiniz");
                    }

                break;
                default:
                Console.WriteLine("Lütfen 1-5 arasında bir seçim yapınız");
                break;

            }
        }
     }
    }
    class Metodlar
    {
        public void Arama(string deger,List<Kisi> list)
        {
             foreach (var item in list)
             {
                 if(item.Isim.Contains(deger) || item.Soyisim.Contains(deger) || item.Tel.Contains(deger))
                    {
                       Console.WriteLine(" Arama Sonuçlarınız: \n**********************************************");
                       Console.WriteLine("isim: {0}",item.Isim);
                       Console.WriteLine("Soyisim: {0}",item.Soyisim);
                       Console.WriteLine("Telefon: {0}",item.Tel);
                       Console.WriteLine("-");
                    }
                  else
                  {
                       Console.WriteLine(" Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.\n* Silmeyi sonlandırmak için : (1) \n* Yeniden denemek için      : (2)");
                       int num = int.Parse(Console.ReadLine());
                       KisiBulunamadi(num);
                  }
             }
        }

        public void RehberiListele(List<Kisi> list)
        {
            Console.WriteLine("Telefon Rehberi");
                    Console.WriteLine("**********************************************");

                    foreach (var item in list)
                    {
                        Console.WriteLine("İsim {0}",item.Isim);
                        Console.WriteLine("Soyisim {0}",item.Soyisim);
                        Console.WriteLine("Telefon {0}",item.Tel);
                        Console.WriteLine("-");

                    }
        }
        public void KisiBulunamadi(int number)
        {
           if(number == 1)
           {
             Environment.Exit(0);
           }
            else if(number == 2)
           {
              return ;
           }
             else
           {
            Console.WriteLine("Yalnızca 1 ve ya 2 değerini girebilirsiniz!");
           }
        }
        public void KisiGuncelle(Kisi item)
        {
           Console.WriteLine(" Lütfen isim giriniz             : ");
                string isim1 = Console.ReadLine();
                item.Isim = isim1;
                Console.WriteLine(" Lütfen soyisim giriniz          :");
                string soyisim2 = Console.ReadLine();
                item.Soyisim = soyisim2;
                Console.WriteLine(" Lütfen telefon giriniz          :");
                string telefon2 = Console.ReadLine();
                item.Tel = telefon2;

           
                Console.WriteLine("Güncellenen isim: " + item.Isim);
                Console.WriteLine("Güncellenen isim: " + item.Soyisim);
                Console.WriteLine("Güncellenen isim: " + item.Tel);  
    }
         public void KisiSil(string adsoyad,List<Kisi> list)
         {
             foreach (var item in list)
                    {
                        if (item.Isim == adsoyad || item.Soyisim == adsoyad)
                        {
                            Console.WriteLine("{0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)", item.Isim);
                            string answer = Console.ReadLine();
                            if (answer == "y")
                            {
                                list.Remove(item);
                                Console.WriteLine("Kisi silinmiştir");
                            }
                            else if(answer == "n")
                            {
                                Console.WriteLine("Kişiyi silmekten vazgeçtiniz");
                            }
                            else
                            {
                                Console.WriteLine("Sadece 'y' ya da 'n' yazabilirsiniz");
                            }
                        }
                        else{
                            Console.WriteLine(" Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.\n* Silmeyi sonlandırmak için : (1) \n* Yeniden denemek için      : (2)");
                            int num = int.Parse(Console.ReadLine());
                            KisiBulunamadi(num);
                        }
                    }
         }
    }
}
