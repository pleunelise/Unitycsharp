using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            float totaalIncBtw = 0.0f;
            Mobiel mobiel1 = new Mobiel("iPhone", "iPhone XS", "Apple IOS", 1159);
            Mobiel mobiel2 = new Mobiel("Pixel", "Pixel3", "Andriod", 949);
            Mobiel mobiel3 = new Mobiel("Samsung", "Samsung A50", "AndriodOne", 299);

            Mobiel[] mobieltjes = new Mobiel[3];
            mobieltjes[0] = mobiel1;
            mobieltjes[1] = mobiel2;
            mobieltjes[2] = mobiel3;

            foreach (Mobiel m in mobieltjes)
            {
                Console.Write(m.type);
               
                switch (m.type)
                {
                    case "iPhone":
                        Console.Write(" = " + mobiel1.prijs + " exclusief BTW");
                        break;
                    case "Pixel":
                        Console.Write(" = " + mobiel2.prijs + " exclusief BTW");
                        break;
                    case "Samsung":
                        Console.Write(" = " + mobiel3.prijs + " exclusief BTW");
                        break;

                }
                Console.WriteLine();
                
            }
            Console.WriteLine("!Gratis verzenging vanaf 350 euro!");
            Console.WriteLine("Welk mobieltje wil je kopen?:");
            string mobieltje = Console.ReadLine();
            Console.WriteLine("Hoeveel " + mobieltje + " wil je?");
            int aantal = Convert.ToInt32(Console.ReadLine());

            if (mobieltje == "iPhone")
            {
                totaalIncBtw = mobiel1.Btw(aantal);
            }

            else if (mobieltje == "Pixel")
            {
                totaalIncBtw = mobiel2.Btw(aantal);
            }
            
            else if (mobieltje == "Samsung")
            {
                totaalIncBtw = mobiel3.Btw(aantal);
            }
            Console.WriteLine("De totale prijs inclusief BTW = " + totaalIncBtw + " euro");
        }
    }
}