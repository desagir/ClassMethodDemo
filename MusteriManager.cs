using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class MusteriManager
    {

        public void Ekle(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("TEBRİKLER MŞTERİ EKLENDİ: " + musteri.Adi, musteri.SoyAdi);

            }

        }
        public void Silme(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {

                Console.WriteLine(" {0} Müsteri Kaydı Silindi: " + musteri.Adi, musteri.SoyAdi, musteri.HesaptakiPara);

            }
        }

        public void Listele(Musteri[] müsteriler)
        {

            foreach (var item in müsteriler)
            {
                Console.WriteLine(item.Adi);
            }
        }




    }
}
