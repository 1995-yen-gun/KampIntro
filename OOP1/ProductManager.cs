using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class ProductManager
    {
        //public void Add(Product product)
        //{
        //    product.ProductName = "Kamera";
        //}
        //public void BiseyYap(int sayi)
        //{
        //    sayi = 99;
        //}
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }
        public int Topla( int sayi1, int sayi2)
        {
            return sayi1+ sayi2;
        }
        public void Topla2(int sayi1, int sayi2)  //void komut veriyor.Git yap-git oluştur bitir.Ama İnt komutunun return ile devamı gelmektedir.
        {
            Console.WriteLine(sayi1+sayi2);
        }
    }

    
}
