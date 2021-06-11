using System;

namespace Proje2
{
    class Program
    {
        public static int select = 0;
        static void Main(string[] args)
        {
            
            Choice();
            if(select < 0 && select > 5)
            {
                Console.WriteLine("1 ila 4 arasında tercih yapınız. Çıkmak için 5 e basınız.");
                select = int.Parse(Console.ReadLine());
            }
            switch(select)
            {
                case 1 :
                    KartEkle();
                    break;
                case 2:
                    BoardListele();
                    break;
                case 3: 
                    KartSil();
                     break;
                case 4:
                    KartTasi();
                    break;
                default:
                break;
            }

        }
    
    static void Choice()
    {
       Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) \n*******************************************\n(1) Board Listelemek\n(2) Board'a Kart Eklemek\n(3) Board'dan Kart Silmek\n(4) Kart Taşımak");
       select = int.Parse(Console.ReadLine());
    }


    public static void KartEkle()   
        {
            Kart kart = new Kart();

            Console.WriteLine("Başlık Giriniz                                  :");
            kart.Baslik = Console.ReadLine();

            Console.WriteLine("İçerik Giriniz                                  :");
            kart.Icerik = Console.ReadLine();

            Console.WriteLine("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  :");
            kart.EnumBuyuk = (Buyukluk)int.Parse(Console.ReadLine());

            Console.WriteLine("Kişi ID Giriniz                                  :");
            kart.KisiId = int.Parse(Console.ReadLine());
            int temp = 0;

            foreach (var item in TakimManager.TakimList)
            {
                if (item.Id == kart.KisiId)
                {
                    temp++;
                    Board.ToDo.Add(kart);
                }
            }
            if (temp == 0)
            {
                Console.WriteLine("Hatalı giriş yaptınız! Girilen ID'ye ait bir kullanıcı bulunamadı.");
            }
            else
            {
                Console.WriteLine("KART BAŞARILI BİR ŞEKİLDE EKLENDİ");
            }
        }

     public static void KartSil()    
        {
            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen kart başlığını yazınız:");
            string baslik = Console.ReadLine();

            int temp = 0;

            foreach (var item in Board.ToDo)
            {
                if (item.Baslik.ToLower() == baslik.ToLower())
                {
                    temp++;
                    Board.ToDo.Remove(item);
                    Console.WriteLine("SİLME İŞLEMİ GERÇEKLEŞTİRİLDİ.");
                    break;
                }
            }
            foreach (var item in Board.InProgress)
            {
                if (item.Baslik.ToLower() == baslik.ToLower())
                {
                    temp++;
                    Board.InProgress.Remove(item);
                    Console.WriteLine("SİLME İŞLEMİ GERÇEKLEŞTİRİLDİ.");
                    break;
                }
            }
            foreach (var item in Board.Done)
            {
                if (item.Baslik.ToLower() == baslik.ToLower())
                {
                    temp++;
                    Board.Done.Remove(item);
                    Console.WriteLine("SİLME İŞLEMİ GERÇEKLEŞTİRİLDİ.");
                    break;
                }
            }

            if (temp == 0)
            {
                Console.WriteLine("Aradığınız kriterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için : (2)");

                int selected = int.Parse(Console.ReadLine());
                if (selected == 1)
                {
                }
                else if (selected == 2)
                {
                    KartSil();
                }
            }
        }

         public static void KartTasi()
        {
            Console.WriteLine("Öncelikle güncellemek istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen kart başlığını yazınız:");
            string baslik = Console.ReadLine();

            Console.WriteLine("Bulunan Kart Bilgileri: ");
            Console.WriteLine("**************************************");

            int temp = 0;
            if (temp == 0)
            {
                foreach (var item in Board.ToDo)
                {
                    if (item.Baslik.ToLower() == baslik.ToLower())
                    {
                        temp++;
                        Console.WriteLine("Başlık      :{0}", item.Baslik);
                        Console.WriteLine("İçerik      :{0}", item.Icerik);
                        Console.WriteLine("Atanan Kişi :{0}", item.KisiId);
                        Console.WriteLine("Büyüklük    :{0}", item.EnumBuyuk);
                        Console.WriteLine("Line        :ToDo");

                        SatırSec();
                        int selected = int.Parse(Console.ReadLine());
                        if (selected == 1)
                        {
                        }
                        else if (selected == 2)
                        {
                            Board.InProgress.Add(item);
                            Board.ToDo.Remove(item);
                        }
                        else if (selected == 3)
                        {
                            Board.Done.Add(item);
                            Board.ToDo.Remove(item);
                        }
                        Console.WriteLine("TAŞIMA İŞLEMİ GERÇEKLEŞTİRİLDİ.");
                        break;
                    }
                }
            }
            if (temp == 0)
            {
                foreach (var item in Board.InProgress)
                {
                    if (item.Baslik.ToLower() == baslik.ToLower())
                    {
                        temp++;
                        Console.WriteLine("Başlık      :{0}", item.Baslik);
                        Console.WriteLine("İçerik      :{0}", item.Icerik);
                        Console.WriteLine("Atanan Kişi :{0}", item.KisiId);
                        Console.WriteLine("Büyüklük    :{0}", item.EnumBuyuk);
                        Console.WriteLine("Line        :InProgress");

                        SatırSec();
                        int selected = int.Parse(Console.ReadLine());
                        if (selected == 1)
                        {
                            Board.ToDo.Add(item);
                            Board.InProgress.Remove(item);
                        }
                        else if (selected == 2)
                        {

                        }
                        else if (selected == 3)
                        {
                            Board.Done.Add(item);
                            Board.InProgress.Remove(item);
                        }
                        Console.WriteLine("TAŞIMA İŞLEMİ GERÇEKLEŞTİRİLDİ.");
                        break;
                    }
                }
            }
            if (temp == 0)
            {
                foreach (var item in Board.Done)
                {
                    if (item.Baslik.ToLower() == baslik.ToLower())
                    {
                        temp++;
                        Console.WriteLine("Başlık      :{0}", item.Baslik);
                        Console.WriteLine("İçerik      :{0}", item.Icerik);
                        Console.WriteLine("Atanan Kişi :{0}", item.KisiId);
                        Console.WriteLine("Büyüklük    :{0}", item.EnumBuyuk);
                        Console.WriteLine("Line        :ToDo");

                        SatırSec();
                        int selected = int.Parse(Console.ReadLine());
                        if (selected == 1)
                        {
                            Board.ToDo.Add(item);
                            Board.Done.Remove(item);
                        }
                        else if (selected == 2)
                        {
                            Board.InProgress.Add(item);
                            Board.Done.Remove(item);
                        }
                        else if (selected == 3)
                        {
                        }
                        Console.WriteLine("TAŞIMA İŞLEMİ GERÇEKLEŞTİRİLDİ.");
                        break;
                    }
                }
            }
        }
     public static void BoardListele()
    {
          Console.WriteLine("TODO Line");
            Console.WriteLine("************************");
            if (Board.ToDo.Count == 0)
            {
                Console.WriteLine("~ BOŞ ~");
            }
            else
            {
                foreach (var item in Board.ToDo)
                {
                    Console.WriteLine("Başlık      :{0}", item.Baslik);
                    Console.WriteLine("İçerik      :{0}", item.Icerik);
                    Console.WriteLine("Atanan Kişi :{0}", item.KisiId);
                    Console.WriteLine("Büyüklük    :{0}", item.EnumBuyuk);
                    Console.WriteLine("-");
                }
            }
            Console.WriteLine();

            Console.WriteLine("IN PROGRESS Line");
            Console.WriteLine("************************");
            if (Board.InProgress.Count == 0)
            {
                Console.WriteLine("~ BOŞ ~");
            }
            else
            {
                foreach (var item in Board.InProgress)
                {
                    Console.WriteLine("Başlık      :{0}", item.Baslik);
                    Console.WriteLine("İçerik      :{0}", item.Icerik);
                    Console.WriteLine("Atanan Kişi :{0}", item.KisiId);
                    Console.WriteLine("Büyüklük    :{0}", item.EnumBuyuk);
                    Console.WriteLine("-");
                }
            }
            Console.WriteLine();

            Console.WriteLine("DONE Line");
            Console.WriteLine("************************");
            if (Board.Done.Count == 0)
            {
                Console.WriteLine("~ BOŞ ~");
            }
            else
            {
                foreach (var item in Board.Done)
                {
                    Console.WriteLine("Başlık      :{0}", item.Baslik);
                    Console.WriteLine("İçerik      :{0}", item.Icerik);
                    Console.WriteLine("Atanan Kişi :{0}", item.KisiId);
                    Console.WriteLine("Büyüklük    :{0}", item.EnumBuyuk);
                    Console.WriteLine("-");
                }
            }
            
    }
    public static void SatırSec()
        {
            Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz:");
            Console.WriteLine("(1) TODO");
            Console.WriteLine("(2) IN PROGRESS");
            Console.WriteLine("(3) DONE");
        }
 }
}

