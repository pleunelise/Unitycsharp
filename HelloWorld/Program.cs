
using System;

namespace Korting
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal1 = 0;
            int getal2 = 1;
            int i = 0;
            while (i <= 20)
            {
                int result = getal1 + getal2;
                Console.WriteLine(result);
                getal1 = getal2;
                getal2 = result;
                i++;
            }


        }
    }
}


