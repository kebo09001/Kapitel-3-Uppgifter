using System;
namespace Uppgift3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in det första talet: ");
            double Tal1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in det andra talet: ");
            double Tal2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Välj ett räknesätt");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraktion");
            Console.WriteLine("3. Multiplikation"); 
            Console.WriteLine("4. Division");
            int val = int.Parse(Console.ReadLine());
            switch (val)
            {
                case 1:
                    Console.WriteLine("Resultat: " + (Tal1 + Tal2));
                    break;
                case 2:
                    Console.WriteLine("Resultat: " + (Tal1 - Tal2));
                    break;
                case 3:
                    Console.WriteLine("Resultat: " + (Tal1 * Tal2));
                    break;
                case 4:
                    if (Tal2 != 0)
                    {
                        Console.WriteLine("Resultat: " + (Tal1 / Tal2));
                    }
                    else
                    {
                        Console.WriteLine("Det andra talet får inte vara noll.");
                    }
                    break;
                default:
                    Console.WriteLine("Välj ett giltigt räknesätt från 1 till 4.");
                    break;

            }
        }
    }
}