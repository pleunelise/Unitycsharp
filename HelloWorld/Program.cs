using System;

namespace HelloWorld
{
    class Program
    {
    
        static void Main(string[] args)
        {
            Mobiel mobiel = new Mobiel();
            mobiel.type = "iPhone";
            mobiel.model = "iPhone XS";
            mobiel.OS = "Apple IOS";

            Console.WriteLine(mobiel.type);

            Console.ReadLine();

        }
    }
}