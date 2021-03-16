using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                MusteriManager musteriManager = new MusteriManager();

                Musteri musteri1 = new Musteri()
                {
                    Id = 0001,
                    TcNo = "1000001",
                    Ad = "Yunus Emre",
                    Soyad = "Bakış",
                };

                Musteri musteri2 = new Musteri()
                {
                    Id = 0002,
                    TcNo = "1000002",
                    Ad = "Ayşenur",
                    Soyad = "Bakış",
                };

                Musteri musteri3 = new Musteri()
                {
                    Id = 0003,
                    TcNo = "1000003",
                    Ad = "Abdulkadir",
                    Soyad = "Bakış",
                };



                musteriManager.MusteriEkleme(musteri1);
                musteriManager.MusteriEkleme(musteri2);
                musteriManager.MusteriEkleme(musteri3);

                musteriManager.MusteriSilme(musteri1);
                musteriManager.MusteriSilme(musteri2);
                musteriManager.MusteriSilme(musteri3);

            }
        }
    }
}
