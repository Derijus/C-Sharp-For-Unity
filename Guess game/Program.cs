using System;

namespace Guess_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welkom bij de Guess Game.");
            for (int pogingen = 3; pogingen != 0; pogingen--)
            {
                Console.WriteLine("Raad het woord. Je hebt nog " + pogingen + " pogingen. (Tip: het verloor een race tegen een schildpad)");
                string raden = Console.ReadLine();
                if (raden.ToLower() == "haas")
                {
                    Console.WriteLine("Je hebt het woord geraden!");
                    break;
                }
                else
                {
                    Console.WriteLine("Fout!");
                }
            }
        }
    }
}