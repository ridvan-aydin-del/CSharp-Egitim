//Do Not Repeat Yourself - DRY - Clean Code
using Metotlar;

Product urun1 = new Product();
urun1.Adi = "Elma";
urun1.Fiyati = 15;
urun1.Aciklama = "Amasya Elması";

Product urun2 = new Product();
urun2.Adi = "Karpuz";
urun2.Fiyati = 80;
urun2.Aciklama = "Diyarbakır Karpuzu";

Product[] urunler = new Product[] {urun1,urun2 };

//type-safe

foreach (Product urun in urunler)
{
    Console.WriteLine("Ürünler = " + urun.Adi);
    Console.WriteLine("Ürünler = " + urun.Fiyati);
    Console.WriteLine("Ürünler = " + urun.Aciklama);
    Console.WriteLine(" ");
}

Console.WriteLine("--------Metotlar-----------");
//Encapsulation
SepetManager sepetManager = new SepetManager();
sepetManager.Ekle(urun1);
sepetManager.Ekle(urun2);

sepetManager.Ekle2("Elma", "Yeşil Elma", 15);
sepetManager.Ekle2("Armut", "Yeşil Armut", 30);
sepetManager.Ekle2("Karpuz", "Yeşil Karpuz", 45);