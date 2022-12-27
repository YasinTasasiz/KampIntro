using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elmasi";

            Urun urun1 = new Urun();

            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elmasi";
            urun1.StokAdeti = 15;

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakir karpuzu";
            urun2.StokAdeti = 45;

            Urun[] urunler = new Urun[] { urun1, urun2 };


            foreach (Urun urun in urunler)
            {
                Console.WriteLine("Urun Adi : " + urun.Adi);
                Console.WriteLine("Urun Fiyati : " + urun.Fiyati);
                Console.WriteLine("Urun Aciklama : " + urun.Aciklama);
                Console.WriteLine("Urun Stok Adeti : "  + urun.StokAdeti);
                Console.WriteLine("-----------");
            }

            Console.WriteLine("--------------Metotlar----------------");

            //instance
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yesil armut", 12, 5);
            sepetManager.Ekle2("Elma", "Yesil elma", 12, 8);
            sepetManager.Ekle2("Karpuz", "D. Karpuzu", 12, 9);

        }
    }

}



