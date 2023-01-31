using System;

namespace ClassIntro1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "Java";
            kurs1.Egitmen = "Serhat Adıyok";
            kurs1.İzlenmeOrani = 75;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "C++";
            kurs2.Egitmen = "Hüseyin Gündüz";
            kurs2.İzlenmeOrani = 54;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Yazılım Developer";
            kurs3.Egitmen = "Varol Sakarya";
            kurs3.İzlenmeOrani = 85;

            // Console.WriteLine(kurs1.KursAdi + ":" + kurs1.Egitmen + ":" + kurs1.İzlenmeOrani);
            //Console.WriteLine(kurs2.KursAdi + ":" + kurs2.Egitmen + ":" + kurs2.İzlenmeOrani);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+":"+kurs.Egitmen+":"+kurs.İzlenmeOrani);
            }

           
            


        }

        class Kurs
        {
            public string KursAdi { get; set; }
            public string Egitmen { get; set;}
            public int İzlenmeOrani { get; set; }



        }
    }
           
        
}
