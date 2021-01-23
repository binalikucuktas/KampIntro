using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //array -dizi

            string[] kurslar = new string[] {"Yazılım Geliştirici Yetiştirme kampı","Programlamaya başlangıç kursu", "Java", "Python" };

            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar)
                {
                    Console.WriteLine(kurs);
                }

            //for (int i = 1; i <= 10; i++) birer birer arttırarak yazar
            //for (int i = 1; i <= 10; i+=2) // 1 den başlayarak 2 şer arttırarak gider.
           
        }
    }
}
