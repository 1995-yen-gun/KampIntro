using System;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 800;
            product1.UnitsInStock = 10;


            Product product2 = new Product { Id = 2,CategoryId = 3, ProductName="KAlem", UnitPrice=35 , UnitsInStock=5};

            //PascalCase    //camelCase  c# büyük küçük harf duyarlıdır.Case büyük-küçük harf caseSensitive
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            productManager.Update(product1);
            Console.WriteLine(product1.ProductName);

            productManager.Topla2(2, 25);

            int toplamSonucu = productManager.Topla(2, 20);
            Console.WriteLine(toplamSonucu * 2);




            //int sayi = 100;
            //productManager.BiseyYap(sayi);
            //Console.WriteLine(sayi);
           
        }
    }
}
