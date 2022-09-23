using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[]args)
        {
            string kurs1 = "yazilim gelistirici gelistirme kampi";
            string kurs2 = "yazilim gelistirici gelistirme kampi";
            string kurs3 = "Java";

            //array dizi

            string[] kurslar = new string[] { "Yazilim gelistirici gelistirme kampi",
                "Programlamaya baslangic icin temel kurs",
                "Java","Python","C++"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For Bitti");
            Console.WriteLine("Foreach Başladı");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("");
            Console.WriteLine("Sayfa SONU - FOOTER");


        }
    }
}