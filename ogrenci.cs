using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciUygulamasi
{
    public class Ogrenci
   {
        private int ogrNo;
        private string isim;
        private string soyisim;
        private int vize1;
        private int vize2;
        private int final;
        private string okulIsmi;

        public Ogrenci(int _ogrNo, string _isim, string _soyisim, int _vize1, int _vize2, int _final, string _okulIsmi )
        {
            ogrNo = _ogrNo;
            isim = _isim;
            soyisim = _soyisim;
            vize1 = _vize1;
            vize2 = _vize2;
            final = _final;
            okulIsmi = _okulIsmi;
        }



        public void ogrenciBilgileriGoster()
        {
            Console.WriteLine("Öğrenci No:" + ogrNo);
            Console.WriteLine("Öğrencinin ismi:" + isim);
            Console.WriteLine("Öğrencinin soyismi:" + soyisim);
            Console.WriteLine("Vize1:" + vize1);
            Console.WriteLine("Vize2:" + vize2);
            Console.WriteLine("Final:" + final);
            Console.WriteLine("Öğrenci okul ismi;" + okulIsmi);

            


        }
        public double ogrenciNotuBul()
        {
            double ortalama = vize1 * 0.2 + vize2 * 0.2 + final * 0.6;

                    return ortalama;
        }

        public void okulGetir()
        {
            Console.WriteLine("Öğrencinin okul ismi:" + okulIsmi);
        }
    }
}
