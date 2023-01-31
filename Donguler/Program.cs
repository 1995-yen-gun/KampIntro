using System;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici kursu";
            string kurs2 = "java";               // bu tip verilerimizi dinamik hale getirmek için array = dizilerde kullanmamız gerekiyor.
            string kurs3 = "c++";               //tek tek string ile yapılması yapılmıyor.Döngü ile yapılması için dizilerde kullanılması gerekiyor.

            //array=dizi

            string[] kurslar = new string[] { "Yazılım Geliştirici kursu",
                "java","c++","Python Geliştirme Kursu" };


            for (int i = 0; i < kurslar.Length; i++) //i=i+2 çift arttır
            {
                Console.WriteLine(kurslar[i]); //for ise daha genel olarak kullanılır.

            }
            Console.WriteLine("for bitti");

            foreach (string kurs in kurslar)   //dizi temelli yapıları tek tek dönmeye yarıyor.for each dizlerde kullanıllır
            {
                Console.WriteLine(kurs);
            }

            for (int i = 0; i <10; i++)
            {
                Console.WriteLine(i);
            }
               Console.WriteLine("sayfa sonu- footer");
        }
    }
}
