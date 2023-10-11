using System;

namespace Lektion03_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CprNr cprNr_s1 = new CprNr("130950", "1741");
            CprNr cprNr_v1 = new CprNr("201060", "5741");
            CprNr cprNr_m1 = new CprNr("301299", "0091");
            CprNr cprNr_m2 = new CprNr("011203", "0777");
            CprNr cprNr_m3 = new CprNr("230102", "4444");

            Synesmand s1 = new Synesmand(cprNr_s1,"01","Kris", "Birkevej 2", 2000, 150, 7);
            Vaerkfoerer v1 = new Vaerkfoerer(cprNr_v1, "02", "Lars", "Gryttevej 7", 1995, 160, 2000, 7000);
            Mekanikere m1 = new Mekanikere(cprNr_m1, "03", "Egon", "Egevej 103", 2017, 130);
            Mekanikere m2 = new Mekanikere(cprNr_m2, "04", "Ole", "viborvej 744", 2021, 120);
            Mekanikere m3 = new Mekanikere(cprNr_m3, "05", "Lau", "Egevej 3", 2022, 100);

            Adresse adresse1 = new Adresse("Birkevj", 7);
            Firma f1 = new Firma(adresse1);
            
            Console.WriteLine(v1.BeregnUgeLoen());
            Console.WriteLine(s1.BeregnUgeLoen());
            Console.WriteLine(v1.ToString());
            Console.WriteLine(m1.ToString());
            Console.WriteLine(m2.ToString());
            Console.WriteLine(m3.ToString());

            Console.ReadLine();

            var medarbejderListe = new MedarbejderListe<IharAdresse>();

            medarbejderListe.AddElement(s1);
            medarbejderListe.AddElement(v1);
            medarbejderListe.AddElement(m1);
            medarbejderListe.AddElement(m2);
            medarbejderListe.AddElement(m3);
            medarbejderListe.AddElement(f1);

            Console.WriteLine(medarbejderListe.ListSize());
            IharAdresse item = medarbejderListe.GetItem(m1.a);

            if (item is Medarbejder medarbejder)
            {
                Medarbejder x = (Medarbejder)item;
                Console.WriteLine(x.ToString());
            }
            else if (item is Firma firma)
            {
                Firma x = (Firma)item;
                Console.WriteLine(x.ToString());
            }
            
            Console.ReadLine();


        }
    }
}
