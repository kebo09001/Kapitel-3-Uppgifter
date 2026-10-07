using System;
namespace Uppgift3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur gammal är du?");
            int ålder = int.Parse(Console.ReadLine());
            switch (ålder)
            {
                case > 19:
                    Console.WriteLine("Du är för gammal för att delta i tävlingen.");
                    break;
                case < 16:
                    Console.WriteLine("Du är för ung för att delta i tävlingen.");
                    break;
                default:
                    Console.WriteLine("Välkommen till tävlingen!");
                    break;
            }
        }
    }
}