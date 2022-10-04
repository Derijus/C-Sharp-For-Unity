using System;

namespace MobielShop
{
    public class Program
    {
        static void Main(string[] args)
        {

            Mobiel iphone = new Mobiel("iPhone", "iPhone XS", "Apple iOS", "Steve Jobs.", 299);

            Mobiel samsung = new Mobiel("Samsung", "Samsung Galaxy S7", "Android", "Kim Ki Nam.", 359);

            Mobiel google = new Mobiel("Google Pixel", "Google Pixel 3", "Chrome OS", "Sundar Pichai.", 226);
            double prijs = 0;
            Console.WriteLine("Welkom bij MobielShop.");
            for (int teller = 0; teller <= 3; teller++)
            {
                Console.WriteLine("U kunt kiezen uit de volgende mogelijkheden (typ 1-3, of typ '0' om af te rekenen)");
                Console.WriteLine("Verzendkosten zijn gratis bij een bestelling van 600,- of hoger (Incl. BTW)");
                Console.WriteLine(iphone.Model + " - " + iphone.Prijs + " ,-");
                Console.WriteLine(samsung.Model + " - " + samsung.Prijs + " ,-");
                Console.WriteLine(google.Model + " - " + google.Prijs + " ,-");
                int keuze = Convert.ToInt32(Console.ReadLine());
                if (keuze == 1)
                {
                    Console.WriteLine("De oprichter van de iPhone is " + iphone.CEO);
                    Console.WriteLine("Hoeveel iPhone XS wilt u bestellen?");
                    double aantal = Convert.ToInt32(Console.ReadLine());
                    prijs += iphone.Prijs * aantal;
                }
                else if (keuze == 2)
                {
                    Console.WriteLine("Een van de CEO's van Samsung is " + samsung.CEO);
                    Console.WriteLine("Hoeveel Samsung Galaxy S7 wilt u bestellen?");
                    double aantal = Convert.ToInt32(Console.ReadLine());
                    prijs += samsung.Prijs * aantal;
                }
                else if (keuze == 3)
                {
                    Console.WriteLine("De CEO van Google is " + google.CEO);
                    Console.WriteLine("Hoeveel Google Pixel 3 wilt u bestellen?");
                    double aantal = Convert.ToInt32(Console.ReadLine());
                    prijs += google.Prijs * aantal;
                }
                else if (keuze == 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Ongeldige invoer.");
                }
            }
            static void BTW(double prijs){}
            double btw = prijs * 0.21;
            double prijsIncl = prijs + btw;
            if (prijs < 600)
            {
                prijs += 50;
                Console.WriteLine("U heeft een prijs van lager dan 500,-, dus u krijgt geen gratis verzending.");
                Console.WriteLine("Verzendkosten:       50,-");
            }
            else
            {
                Console.WriteLine("U heeft een bestelling van 600,- of hoger, dus u krijgt gratis verzending.");
            }
            Console.WriteLine("Prijs exclusief BTW: " + prijs);
            Console.WriteLine("Prijs inclusief BTW: " + prijsIncl);
        }
    }
}
