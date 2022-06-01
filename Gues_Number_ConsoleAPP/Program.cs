using System;

namespace Gues_Number_ConsoleAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int sayi;
            int tahmin = -1;
            byte puan = 0;
            char devam = 'E';

            Console.WriteLine("Sayı Tahmin Oyununa Hoşgeldiniz. \n0-100 arasında rastgele bir sayi var. \nBu sayiyı tahim etmeniz gerekiyor. \n100 puandan başlarsınız her tahminde 10 puanınız azalır.\nHadi Başlayalım!");


            while (devam == 'E' || devam == 'e')
            {
                sayi = rnd.Next(0, 100);
                //Console.WriteLine("Tahmin edeceğiniz sayi:" + sayi); ;
                while (true)
                {
                    Console.WriteLine("\nLütfen Tahmininizi Giriniz : ");
                    Int32.TryParse(Console.ReadLine(), out tahmin);
                    if (tahmin < sayi)
                    {
                        Console.WriteLine("Daha Büyük Tahmin etmeye çalışın..");
                        puan -= 10;
                    }
                    if (tahmin > sayi)
                    {
                        Console.WriteLine("Daha Küçük tahmin etmeye çalışın..");
                        puan -= 10;
                    }

                    if (tahmin == sayi)
                    {
                        puan += 100;
                        Console.WriteLine("Tebrikler! Tahmininiz Doğru. Puanınız : " + puan);
                        break;
                    }
                }
                Console.WriteLine("DEVAM ETMEK İSTER MİSİNİZ? E/H ");
                char.TryParse(Console.ReadLine(), out devam);

            }
        }
    }
}

