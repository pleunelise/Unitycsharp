
using System;

namespace Korting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wil je de volgende getallen '+', '-', 'x' of '/' doen?");
            string input = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Geef een getal:");
            int getal1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Geef nog een gatal:");
            int getal2 = Convert.ToInt16(Console.ReadLine());
            if (input == "+")
            { 
                int result1 = getal1 + getal2;
                Console.Write("{0} + {1} = {2}", getal1, getal2, result1);
            }
            else if (input == "-")
            {
                int result2 = getal1 - getal2;
                Console.Write("{0} - {1} = {2}", getal1, getal2, result2);
            }
            else if (input == "x")
            { 
                int result3 = getal1 * getal2;
                Console.Write("{0} * {1} = {2}", getal1, getal2, result3);
            }
            else if (input == "/")
            { 
                int result4 = getal1 / getal2;
                Console.Write("{0} / {1} = {2}", getal1, getal2, result4);
            }

            Console.ReadLine();
        }
    }
}


