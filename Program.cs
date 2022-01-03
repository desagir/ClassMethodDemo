using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Eren";
            musteri1.SoyAdi = "SAĞIR";
            musteri1.HesaptakiPara = 100000;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Kenan";
            musteri2.SoyAdi = "Acemoglu";
            musteri2.HesaptakiPara = 1000000;

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Vahit";
            musteri3.SoyAdi = "Kurt";
            musteri3.HesaptakiPara = 1000000;

            MusteriManager musteriManager = new MusteriManager();


            Console.WriteLine("------MUSTERİ EKLEME-----");

            Musteri[] musteriler = new Musteri[] {musteri1,musteri2,musteri3 };
            musteriManager.Ekle(musteriler);

            Console.WriteLine("----------MUSTERİ LİSTELEME------");
            musteriManager.Listele(musteriler);

            Console.WriteLine("-----MUSTERİ SİLME-----");
            musteriManager.Silme(musteriler);


        }
    }
}
