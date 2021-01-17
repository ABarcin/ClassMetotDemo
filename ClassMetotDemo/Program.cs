using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 0;
            musteri1.Name = "Ahmet";
            musteri1.Surname = "Barçın";
            musteri1.PhoneNumber = "05370000000";
            musteri1.Adress = "Kocaeli";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 1;
            musteri2.Name = "Mehmet";
            musteri2.Surname = "Barçın";
            musteri2.PhoneNumber = "05360000000";
            musteri2.Adress = "İstanbul";
            Musteri musteri3 = new Musteri();

            musteri3.Id = 2;
            musteri3.Name = "Muhammed";
            musteri3.Surname = "Barçın";
            musteri3.PhoneNumber = "05350000000";
            musteri3.Adress = "Bursa";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Edit(musteri2);
            musteriManager.Delete(musteri3);
            musteriManager.ListMusteri(musteri1);
            musteriManager.ListAllMusteriler(musteriler);

        }
    }
}
