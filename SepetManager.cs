using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        public void Ekle(Product produt)
        {
            Console.WriteLine("Sepete eklendi:" + produt.Adi);
        }
        public void Ekle2(string urunAdi, string aciklama, double fiyat, double stokAdedi)
        {
            Console.WriteLine("Sepete eklendi: " + urunAdi);
        }
    }
}
