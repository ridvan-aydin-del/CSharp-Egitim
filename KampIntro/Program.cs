using System;
namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - 
            //Do not repeat yourself - 
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;

            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalis Butonu");
            }

            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artis Butonu");
            }

            else
            {
                Console.WriteLine("Esittir Butonu");
            }

            if (sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            Console.WriteLine(kategoriEtiketi);
            


        }
    }
}