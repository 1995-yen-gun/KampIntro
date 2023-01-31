using System;

namespace KampIntro1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //typeSafety - tip güvenliği
            //Do not repeat yourself 
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayısı = 3254;
            double faizOranı = 1.65;             
            bool SistemeGirisYapmısMi = true;
            double dolarDun = 7.85;
            double dolarBugun = 7.45;


            if (SistemeGirisYapmısMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları Butonu");      
            }
            else
            {
                Console.WriteLine("Giriş yap Butonu");
            }
            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else 
            {
                Console.WriteLine("Değişmedi butonu");
            }
            Console.WriteLine(kategoriEtiketi);
           
            
        }
    }
}
