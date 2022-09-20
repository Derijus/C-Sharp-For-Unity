using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal1 = 0;
            int getal2 = 1;
            int getal3 = 1;
            Console.WriteLine("Dit zijn de eerste 20 getallen uit de fibonacci-reeks.");
            for (int i = 0; getal3 <= 6766; i++)
            {
                Console.WriteLine(getal1);
                Console.WriteLine(getal2);
                Console.WriteLine(getal3);
                getal1 = getal2 + getal3;
                getal2 = getal1 + getal3;
                getal3 = getal1 + getal2;
            }
        }
    }
}