using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musterilerimiz1 = new Musteri();
            musterilerimiz1.musteriAd = "Sinan";
            musterilerimiz1.musteriSoyad = "Hacı";
            musterilerimiz1.musteriTC = 1234567891;
            musterilerimiz1.musteriBakiye = 500;

            Musteri musterilerimiz2 = new Musteri();
            musterilerimiz2.musteriAd = "Oğuz";
            musterilerimiz2.musteriSoyad = "Lale";
            musterilerimiz2.musteriTC = 2345678912;
            musterilerimiz2.musteriBakiye = 150;

            Musteri musterilerimiz3 = new Musteri();
            musterilerimiz3.musteriAd = "Ahmet";
            musterilerimiz3.musteriSoyad = "Öklit";
            musterilerimiz3.musteriTC = 3456789123;
            musterilerimiz3.musteriBakiye = 1000;

            Musteri musterilerimiz4 = new Musteri();
            musterilerimiz4.musteriAd = "Fikri";
            musterilerimiz4.musteriSoyad = "Güzel";
            musterilerimiz4.musteriTC = 4567891234;
            musterilerimiz4.musteriBakiye = 10;

            Musteri[] musteriList = new Musteri[] { musterilerimiz4, musterilerimiz3, musterilerimiz2, musterilerimiz1 };

            MusteriManager musteriManager = new MusteriManager();
            Console.WriteLine("--------Eklenen Müşteriler--------");
            musteriManager.MusteriEkle(musterilerimiz1);
            musteriManager.MusteriEkle(musterilerimiz2);
            musteriManager.MusteriEkle(musterilerimiz3);
            musteriManager.MusteriEkle(musterilerimiz4);
            Console.WriteLine("----------------------------------");
            Console.WriteLine("------------Müşteriler------------");
            musteriManager.MusteriBilgileriGetir(musterilerimiz1);
            musteriManager.MusteriBilgileriGetir(musterilerimiz2);
            musteriManager.MusteriBilgileriGetir(musterilerimiz3);
            musteriManager.MusteriBilgileriGetir(musterilerimiz4);
            Console.WriteLine("----------------------------------");
            Console.WriteLine("--------Silinen Müşteriler--------");
            musteriManager.MusteriSil(musterilerimiz1);
            musteriManager.MusteriSil(musterilerimiz2);
            musteriManager.MusteriSil(musterilerimiz3);
            musteriManager.MusteriSil(musterilerimiz4);


        }
    }
}
