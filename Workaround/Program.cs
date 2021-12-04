using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            SelamVer("Taner");
            SelamVer("Taner");
            SelamVer("Taner");
            SelamVer();

            int sonuc = Topla(6,58);

            //Diziler / Arrays

            string ogrneci1 = "Engin";
            string ogrneci2 = "Kerem";
            string ogrneci3 = "Berkay";

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Engin";
            ogrenciler[1] = "Kerem";
            ogrenciler[2] = "Berkay";
            
            ogrenciler = new string[4];
            ogrenciler[3] = "İlker";

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[1]);

            Person person1 = new Person();
            person1.NationalIdentity = 53317237416;
            person1.FirstName = "TANER";
            person1.LastName = "SAYDAM";
            person1.DateOfBirthYear = 1989;

            //Person person2 = new Person();
            //person1.FirstName = "Murat";

            foreach (var sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }

            //MyList
            List<string> yeniSehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };
            yeniSehirler1.Add("Adana 1");

            foreach (var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);


            Console.ReadLine();
        }

        //Metot void sadece işi yapar.
        //Resharper
        static void SelamVer(string isim = "NoName")
        {
            Console.WriteLine("Merhaba " + isim);
        }       

        static int Topla(int sayi1 = 5, int sayi2 = 10)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam : " + sonuc);
            return sonuc;
        }
    }
}
