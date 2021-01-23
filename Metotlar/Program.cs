using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";


            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakir karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };


            // type-safe
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
            }

            Console.WriteLine("-------Metotlar----");

            //instance 
            //encapsulation
            SepetManager sepetmanger = new SepetManager();
            sepetmanger.Ekle(urun1);
            sepetmanger.Ekle(urun2);
            

        }
    }
}


// metotlar tekrar tekrar kullanlıan sistemler için kullanılır. Do not repeat yourself- DRY - Clean code