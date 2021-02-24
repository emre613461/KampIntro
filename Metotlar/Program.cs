using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";


            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";


            Urun[] urunler = new Urun[] {urun1,urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);

            }

            Console.WriteLine("-------------Metotlar----------------");
            SepetManeger sepetManeger = new SepetManeger();
            sepetManeger.Ekle(urun1);
            sepetManeger.Ekle(urun2);

            sepetManeger.Ekle2("Armut", "Yeşil Armut", 12, 10);
            sepetManeger.Ekle2("Elma", "Yeşil Elma", 15, 12);
            sepetManeger.Ekle2("İncir", "Yeşil İncir", 10, 15);
        }
    }
}
