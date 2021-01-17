using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.musteriAd + " " + musteri.musteriSoyad + " isimli müşteri sisteme eklendi");
        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.musteriAd + " " + musteri.musteriSoyad + " isimli müşteri sistemden silindi");
        }
        public void MusteriBilgileriGetir(Musteri musteri)
        {
            Console.WriteLine("Ad" + " " +musteri.musteriAd + " " + " Soyad " + " " + musteri.musteriSoyad + " " + "TC No" + " " + musteri.musteriTC + " " + "Bakiye" + " " +musteri.musteriBakiye);
        }
    }
}
