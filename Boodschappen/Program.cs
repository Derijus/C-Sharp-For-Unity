using System;

namespace Boodschappen
{
    class Program
    {
        static void Main(string[] args)
        {
            double prijs = 0;
            for (int keuzes = 1; keuzes <= 3; keuzes++)
            {
                Console.WriteLine("Welkom bij het boodschappenprogramma. U kunt kiezen uit (typ 1 - 10):");
                Console.WriteLine("1 - Water: 1 euro");
                Console.WriteLine("2 - Brood: 2 euro");
                Console.WriteLine("3 - Frisdrank: 3 euro");
                Console.WriteLine("4 - Sap: 3 euro");
                Console.WriteLine("5 - Toast: 4 euro");
                Console.WriteLine("6 - Taart: 4 euro");
                Console.WriteLine("7 - Koffie: 5 euro");
                Console.WriteLine("8 - Wijn: 6 euro");
                Console.WriteLine("9 - Sushi: 8 euro");
                Console.WriteLine("10 - Kookboek: 10 euro");
                int keuze = Convert.ToInt32(Console.ReadLine());
                if (keuze == 1)
                {
                    Console.WriteLine("Hoeveel wil je hier van?");
                    int aantal = Convert.ToInt32(Console.ReadLine());
                    prijs += 1 * aantal;
                }
                else if (keuze == 2)
                { 
                    Console.WriteLine("Hoeveel wil je hier van?");
                    int aantal = Convert.ToInt32(Console.ReadLine());
                    prijs += 2 * aantal;
                }
                else if (keuze == 3 || keuze == 4)
                {
                    Console.WriteLine("Hoeveel wil je hier van?");
                    int aantal = Convert.ToInt32(Console.ReadLine());
                    prijs += 3 * aantal;
                }
                else if (keuze == 5 || keuze == 6)
                {
                    Console.WriteLine("Hoeveel wil je hier van?");
                    int aantal = Convert.ToInt32(Console.ReadLine());
                    prijs += 4 * aantal;
                }
                else if (keuze == 7)
                {
                    Console.WriteLine("Hoeveel wil je hier van?");
                    int aantal = Convert.ToInt32(Console.ReadLine());
                    prijs += 5 * aantal;
                }
                else if (keuze == 8)
                {
                    Console.WriteLine("Hoeveel wil je hier van?");
                    int aantal = Convert.ToInt32(Console.ReadLine());
                    prijs += 6 * aantal;
                }
                else if (keuze == 9)
                {
                    Console.WriteLine("Hoeveel wil je hier van?");
                    int aantal = Convert.ToInt32(Console.ReadLine());
                    prijs += 8 * aantal;
                }
                else if (keuze == 10)
                {
                    Console.WriteLine("Hoeveel wil je hier van?");
                    int aantal = Convert.ToInt32(Console.ReadLine());
                    prijs += 10 * aantal;
                }
                else
                {
                    Console.WriteLine("Ongeldige invoer.");
                }
            }
            double btw = prijs * 0.21;
            prijs += btw;
            Console.WriteLine("Je boodschappen kosten " + prijs + " euro. (incl. BTW)");
        }
    }
}