using System;

namespace HelloWorld
{
    public class Mobiel
    {
        public string type;
        public string model;
        public string OS;

        public Mobiel(string nType, string nModel, string nOS)
        {
            type = nType;
            model = nModel;
            OS = nOS;
        }
    }
}