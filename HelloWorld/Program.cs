using System;

namespace Boodschappen
{
    class Program
    {
        static void Main(string[] args)
        {
            const string product1 = "Koffie";
            const string product2 = "Melk";
            const string product3 = "Limonade";
            const string product4 = "Snoep";
            const string product5 = "Chips";
            const string product6 = "Chocolade";
            const string product7 = "Koekjes";
            const string product8 = "Water";
            const string product9 = "Paprika";
            const string product10 = "Komkommer";
            string header = "====================";

            float totaal = 0.0f;
            float prijs = 0.0f;
            float prijsExclBtw = 0.0f;
            float prijsExclBtw1 = 3.95f;
            float prijsExclBtw2 = 2.95f;
            float prijsExclBtw3 = 1.95f;
            float prijsExclBtw4 = 2.70f;
            float prijsExclBtw5 = 3.20f;
            float prijsExclBtw6 = 2.20f;
            float prijsExclBtw7 = 1.20f;
            float prijsExclBtw8 = 0.95f;
            float prijsExclBtw9 = 1.90f;
            float prijsExclBtw10 = 1.05f;
            const float btwPercentage = 0.21f;

            Console.WriteLine(header);
            Console.WriteLine(product1 + " = " + prijsExclBtw1);
            Console.WriteLine(product2 + " = " + prijsExclBtw2);
            Console.WriteLine(product3 + " = " + prijsExclBtw3);
            Console.WriteLine(product4 + " = " + prijsExclBtw4);
            Console.WriteLine(product5 + " = " + prijsExclBtw5);
            Console.WriteLine(product6 + " = " + prijsExclBtw6);
            Console.WriteLine(product7 + " = " + prijsExclBtw7);
            Console.WriteLine(product8 + " = " + prijsExclBtw8);
            Console.WriteLine(product9 + " = " + prijsExclBtw9);
            Console.WriteLine(product10 + " = " + prijsExclBtw10);
            Console.WriteLine(header);

            for (int teller = 1; teller <= 3; teller++)
            {
                Console.WriteLine("Kies een product:");
                string product = Console.ReadLine();
                Console.WriteLine(header);
                Console.WriteLine("Hoeveel " + product + " wil je?");
                int aantal = Convert.ToInt32(Console.ReadLine());

                switch (product)
                {
                case "Koffie":
                    prijs = aantal * prijsExclBtw1 + (aantal * prijsExclBtw1) * btwPercentage;
                    prijsExclBtw = getBTW(product, aantal, prijsExclBtw1, btwPercentage);
                    Console.WriteLine(header);
                    Console.WriteLine("Prijs inclusief BTW: " + prijs + " euro");
                    break;
                case "Melk":
                    prijs = aantal * prijsExclBtw2 + (aantal * prijsExclBtw2) * btwPercentage;
                    prijsExclBtw = getBTW(product, aantal, prijsExclBtw2, btwPercentage);
                    Console.WriteLine(header);
                    Console.WriteLine("Prijs inclusief BTW: " + prijs + " euro");
                    break;
                case "Limonade":
                    prijs = aantal * prijsExclBtw3 + (aantal * prijsExclBtw3) * btwPercentage;
                    prijsExclBtw = getBTW(product, aantal, prijsExclBtw3, btwPercentage);
                    Console.WriteLine(header);
                    Console.WriteLine("Prijs inclusief BTW: " + prijs + " euro");
                    break;
                case "Snoep":
                    prijs = aantal * prijsExclBtw4 + (aantal * prijsExclBtw4) * btwPercentage;
                    prijsExclBtw = getBTW(product, aantal, prijsExclBtw4, btwPercentage);
                    Console.WriteLine(header);
                    Console.WriteLine("Prijs inclusief BTW: " + prijs + " euro");
                    break;
                case "Chips":
                    prijs = aantal * prijsExclBtw5 + (aantal * prijsExclBtw5) * btwPercentage;
                    prijsExclBtw = getBTW(product, aantal, prijsExclBtw5, btwPercentage);
                    Console.WriteLine(header);
                    Console.WriteLine("Prijs inclusief BTW: " + prijs + " euro");
                    break;
                case "Chocolade":
                    prijs = aantal * prijsExclBtw6 + (aantal * prijsExclBtw6) * btwPercentage;
                    prijsExclBtw = getBTW(product, aantal, prijsExclBtw6, btwPercentage);
                    Console.WriteLine(header);
                    Console.WriteLine("Prijs inclusief BTW: " + prijs + " euro");
                    break;
                case "Koekjes":
                    prijs = aantal * prijsExclBtw7 + (aantal * prijsExclBtw7) * btwPercentage;
                    prijsExclBtw = getBTW(product, aantal, prijsExclBtw7, btwPercentage);
                    Console.WriteLine(header);
                    Console.WriteLine("Prijs inclusief BTW: " + prijs + " euro");
                    break;
                case "Water":
                    prijs = aantal * prijsExclBtw8 + (aantal * prijsExclBtw8) * btwPercentage;
                    prijsExclBtw = getBTW(product, aantal, prijsExclBtw8, btwPercentage);
                    Console.WriteLine(header);
                    Console.WriteLine("Prijs inclusief BTW: " + prijs + " euro");
                    break;
                case "Paprika":
                    prijs = aantal * prijsExclBtw9 + (aantal * prijsExclBtw9) * btwPercentage;
                    prijsExclBtw = getBTW(product, aantal, prijsExclBtw9, btwPercentage);
                    Console.WriteLine(header);
                    Console.WriteLine("Prijs inclusief BTW: " + prijs + " euro");
                    break;
                case "Komkommer":
                    prijs = aantal * prijsExclBtw10 + (aantal * prijsExclBtw10) * btwPercentage;
                    prijsExclBtw = getBTW(product, aantal, prijsExclBtw10, btwPercentage);
                    Console.WriteLine(header);
                    Console.WriteLine("Prijs inclusief BTW: " + prijs + " euro");
                    break;
                default :
                    Console.WriteLine("!!dit product is niet beschikbaar!!");
                    break;
                }
                Console.WriteLine(header);
                totaal = prijs + totaal;
                Console.WriteLine("Dit kost in totaal: " + totaal + " euro");
                Console.WriteLine(header);  
            }
            
        }
        public static float getBTW(string product, int aantal, float prijsExclBtw, float btwPercentage)
        {
            float btw = 0.0f;
            btw = (aantal * prijsExclBtw + (aantal * prijsExclBtw) * btwPercentage) - (aantal * prijsExclBtw);
            Console.WriteLine("De btw: " + btw + " euro");
            return btw;
                
               
        }
    }
}