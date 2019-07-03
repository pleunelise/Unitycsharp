using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Mobiel mobiel1 = new Mobiel("iPhone", "iPhone XS", "Apple IOS");
            Mobiel mobiel2 = new Mobiel("Pixel", "Pixel3", "Andriod");
            Mobiel mobiel3 = new Mobiel("Samsung", "Samsung A5", "AndriodOne");

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
                        Console.Write(" Steve Jobs");
                        break;
                    case "Pixel":
                        Console.Write(" Sundar Pichai");
                        break;
                    case "Samsung":
                        Console.Write(" Kim Ki Nam");
                        break;

                }
                Console.WriteLine();
            }

        }
    }
}