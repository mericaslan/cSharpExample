using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciUygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool kontrol = true;
            Ogrenci ogrenci1 = new Ogrenci(1,"Meriç","Aslan",50,40,73,"Marmara Üniversitesi");

            Console.WriteLine("Uygulumamıza Hoşgeldiniz... Yapmak istediğiniz işlemi seçiniz.");

            islemleriGoster();


            while (kontrol)
            {
                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        ogrenci1.ogrenciBilgileriGoster();
                        break;

                    case "2":
                        double ogrenciOrtalama = ogrenci1.ogrenciNotuBul();
                        Console.WriteLine("Öğrencinin ortalaması:" + ogrenciOrtalama);
                        break;

                    case "3":
                        ogrenci1.okulGetir();
                        break;

                    case "4":
                        kontrol = false;
                        break;


                }


            }

            










        }

        static void islemleriGoster()
        {
            Console.WriteLine("1- Öğrenci Bilgileri Göster");
            Console.WriteLine("2- Öğrenci ortalamasını göster");
            Console.WriteLine("3- Öğrenci okulunu göster");
            Console.WriteLine("4- Çıkış yap...");
        }
    }
}
