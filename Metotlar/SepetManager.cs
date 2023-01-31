using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class SepetManager
    {
        //naming convention
        //syntax

        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikkkler Sepete eklendi : " + urun.Adi);
            Console.WriteLine(urun.Aciklama);
            Console.WriteLine(urun.Fiyati);
            Console.WriteLine(urun.StokAdedi);
          
        }
        

        public void Ekle2(string urunAdi,string acıklma,double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikkkler Sepete eklendi : " + urunAdi);
            

        }
      

    }
}
