using System;

namespace HelloWorld
{
    public class Mobiel
    {
        public string type;
        public string model;
        public string OS;
        public int prijs;
        const float btw = 0.21f;


        public Mobiel(string nType, string nModel, string nOS, int nPrijs)
        {
            type = nType;
            model = nModel;
            OS = nOS;
            prijs = nPrijs;
        }
        public float Btw(int aantal)
        {
            return aantal * prijs + ((aantal * prijs) * btw);
        }

    }
}