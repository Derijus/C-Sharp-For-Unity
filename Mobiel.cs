using System;

namespace MobielShop
{
    public class Mobiel
    {
        public string Type;
        public string Model;
        public string OS;
        public string CEO;
        public double Prijs;
        public Mobiel(string nType, string nModel, string nOS, string nCEO, double nPrijs)
        {
            Type = nType;
            Model = nModel;
            OS = nOS;
            CEO = nCEO;
            Prijs = nPrijs;
        }
    }
}