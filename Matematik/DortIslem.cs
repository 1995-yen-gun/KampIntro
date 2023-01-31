using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    internal class DortIslem    
    {
        public void Topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Sonuç:"+ toplam);

        }

        public void Cıkar(int sayi1, int sayi2)
        { 
            int çıkarma=sayi1 - sayi2;
            Console.WriteLine("Sonuç:" + çıkarma);
        }
            
    }
}
