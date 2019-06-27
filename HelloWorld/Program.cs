using System;

namespace Boodschappen
{
    class Program
    {
        static void Main(string[] args)
        {
            string product1 = "Koffie";
            string product2 = "Melk";
            string product3 = "Limonade";
            string product4 = "Snoep";
            string product5 = "Chips";
            string product6 = "Chocolade";
            string product7 = "Koekjes";
            string product8 = "Water";
            string product9 = "Paprika";
            string product10 = "Komkommer";

            int aantal;
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
            float btwPercentage = 0.21f;
           
            Console.WriteLine("Een pak " + product1 + " kost " + prijsExclBtw1 + " ex btw.");
            Console.WriteLine("Een pak " + product2 + " kost " + prijsExclBtw2 + " ex btw.");
            Console.WriteLine("Een fles " + product3 + " kost " + prijsExclBtw3 + " ex btw.");
            Console.WriteLine("Een zakje " + product4 + " kost " + prijsExclBtw4 + " ex btw.");
            Console.WriteLine("Een zak " + product5 + " kost " + prijsExclBtw5 + " ex btw.");
            Console.WriteLine("Een reep " + product6 + " kost " + prijsExclBtw6 + " ex btw.");
            Console.WriteLine("Een pak " + product7 + " kost " + prijsExclBtw7 + " ex btw.");
            Console.WriteLine("Een fles " + product8 + " kost " + prijsExclBtw8 + " ex btw.");
            Console.WriteLine("Een " + product9 + " kost " + prijsExclBtw9 + " ex btw.");
            Console.WriteLine("Een " + product10 + " kost " + prijsExclBtw10 + " ex btw.");

            Console.WriteLine("Voer een aantal in: ");

            aantal = Convert.ToInt32(Console.ReadLine());
            float totaalPrijs = aantal * prijsExclBtw1 + (aantal * prijsExclBtw1) * btwPercentage;

            Console.WriteLine(aantal + " pakken " + product1 + " kost in totaal " + totaalPrijs);

        }
    }
}
