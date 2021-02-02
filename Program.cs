using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";
            urun1.stokAdedi = 20;

            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama= "Diyarbakir karpuzu";
            urun2.stokAdedi = 35;

            Product[] urunler = new Product[] { urun1, urun2 };

            //type-safe
            foreach(Product urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.stokAdedi);
                Console.WriteLine("------------");
            }

            Console.WriteLine("-----Metotlar------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12, 15);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12, 20);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12, 23);


        }
    }
}


//dont repeat yourself - DRYmn 