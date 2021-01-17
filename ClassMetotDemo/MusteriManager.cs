using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine(musteri.Name +"  İsimli Müşteri Eklenmiştir");
            Console.WriteLine(" ------------------------");
        }
        public void Delete(Musteri musteri)
        {
            Console.WriteLine(musteri.Id+" Numaralı Id e Sahip Müşteri Silinmiştir.");
            Console.WriteLine(" ------------------------");
        }
        public void Edit(Musteri musteri)
        {
            Console.WriteLine(musteri.Id+" Numaralı Id e Sahip Müşteri Düzenlenmiştir.");
            Console.WriteLine(" ------------------------");
        }
        public void ListMusteri(Musteri musteri)
        {
            Console.WriteLine(musteri.Id+" Numaralı Müşteri Bilgileri Aşağıda Listelenmiştir.");
            Console.WriteLine(musteri.Name +" " +musteri.Surname);
            Console.WriteLine(musteri.PhoneNumber);
            Console.WriteLine(musteri.Adress);
            Console.WriteLine(" ------------------------");
        }
        public void ListAllMusteriler(Musteri[] musteriler)
        {
            Console.WriteLine("Tüm Müşteri Isimleri Aşağıda Listelenmiştir.");
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Name + " " + musteri.Surname);
                Console.WriteLine(" ------------------------");
            }
        }
    }
}
