using System;

namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            string[] meyveler = new string[] {"Elma", "Karpuz" };

            Urun urun1 = new Urun();

            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasaya Elması";
            urun1.StokAdedi= 15;

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";
            urun2.StokAdedi = 20;

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urunAdi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.StokAdedi);
                Console.WriteLine("-----------------------");
            }
          
            Console.WriteLine("---------Metotlar-----------");

            SepetManager sepetManager= new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12, 25);
            sepetManager.Ekle2("Çilek", "İzmir Çilek", 75, 41);
            sepetManager.Ekle2("Pırasa", "Edirne Pırasa", 54, 21);

        }
    }
}
// string urunAdi2 = "çilek";
// double fiyati2 = 25;
// string acıklama2 = "Çilek Çilek olalı böyle Çilek Görmedi";

// string[] meyveler = new string[] { };

// 3 satır beraber bir ürünü tanımlar ama bunu class oluşturarak 
//yapmamız gerekiyor.


//do not repeat yourself- DRY -Clean code -Best practice



