using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention
        public void Ekle(Product urun)
        {
            Console.WriteLine("SEPETE EKLENDİ : "+ urun.Adi);
        }
        public void Ekle2(string urunAdi,string aciklama,double fiyat)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : "+urunAdi);
        }
    }
}
