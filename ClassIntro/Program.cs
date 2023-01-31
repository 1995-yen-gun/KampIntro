using System;

namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Ajda ege";
            kurs1.İzlenmeOranı = 85;

            //Console.WriteLine(kurs1.KursAdi+ ":"+kurs1.Egitmen+ ":"+kurs1.İzlenmeOranı);
            Kurs[] kurslar = new Kurs[] { kurs1 };

    }
    

