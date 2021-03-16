using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkleme(Musteri musteri)
        {
            Console.WriteLine("\nMüşteri Eklendi! " +
                "\nId :" + musteri.Id +
                "\nAd :" + musteri.Ad +
                "\nSoyad :" + musteri.Soyad +
                "\nTcNo :" + musteri.TcNo);
        }

        public void MusteriSilme(Musteri musteri)
        {
            Console.WriteLine("\nMüşteri Silindi! " +
                "\nId :" + musteri.Id +
                "\nAd :" + musteri.Ad +
                "\nSoyad :" + musteri.Soyad +
                "\nTcNo :" + musteri.TcNo );
        }

    }
}
