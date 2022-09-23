using System;
namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 35;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demirog";
            kurs1.IzlenmeOrani = 68;

            //Console.WriteLine(kurs1.KursAdi);

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Python";
            kurs2.Egitmen = "Ridvan Demirog";
            kurs2.IzlenmeOrani = 49;

            //Console.WriteLine(kurs2.Egitmen);

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Java";
            kurs3.Egitmen = "Emirhan Demirog";
            kurs3.IzlenmeOrani = 29;

            //Console.WriteLine(kurs3.IzlenmeOrani);

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "Zortingen Ridvan";
            kurs4.IzlenmeOrani = 100;

            Kurs[] kursOzellikleriTop = new Kurs[]
            {
                kurs1,kurs2,kurs3,kurs4
            };
            foreach (var kurs in kursOzellikleriTop)
            {
                Console.WriteLine(kurs.KursAdi+":"+kurs.Egitmen);
            }



            /*Console.Write("[1-10] arasında sayı giriniz :");
            int sayi = int.Parse(Console.ReadLine());
            string cevap = "";
            cevap += sayi == 7 ? "Tebrikler doğru bildiniz" : "Yanlış cevap";
            Console.WriteLine(cevap);*/

            Console.Write("Bir Sayı Giriniz= ");
            int sayi = int.Parse(Console.ReadLine());
            switch (sayi)
            {
                case 1:
                    Console.WriteLine("Birinci Durumdasınız!");
                    break;

                case 2:
                    Console.WriteLine("İkinci Durumdasınız!");
                    break;

                default:
                    Console.WriteLine("Default Konumdasınız!");
                    break;
            }



        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }

}