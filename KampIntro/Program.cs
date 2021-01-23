using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Do not repat yourself
            // type safety
            String kategorietiketi = "kategori";
            int ogrencisayisi = 32000;
            double faizorani = 1.45;
            bool sistemegirisyapmismi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }

            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu")
            }



        }
    }
}
