using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welkom bij de C#-Calculator.");
            Console.WriteLine("Geef een getal.");
            double getal1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Optellen(typ +), aftrekken(typ -), vermenigvuldigen(typ X), of delen(typ /)?");
            string operat = Console.ReadLine();
            Console.WriteLine("Geef het tweede getal.");
            double getal2 = Convert.ToInt32(Console.ReadLine());
            double uitkomst = 0;
            if (operat == "+")
            {
                uitkomst = getal1 + getal2;
            }
            else if (operat == "-")
            {
                uitkomst = getal1 - getal2;
            }
            else if (operat == "X")
            {
                uitkomst = getal1 * getal2;
            }
            else if (operat == "/")
            {
                if (getal2 != 0)
                {
                    uitkomst = getal1 / getal2;
                }
                else
                {
                    Console.WriteLine("Je kan niet delen door 0.");
                }
            }
            else
            {
                Console.WriteLine("Dit is geen geldige invoer.");
            }
            Console.WriteLine("De uitkomst is " + uitkomst);
        }
    }
}