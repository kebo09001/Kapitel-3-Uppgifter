using System;
namespace Uppgift3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur lång är låten? Ange i minuter:");
            int minutes = int.Parse(Console.ReadLine()) * 60;
            Console.WriteLine("Ange sekunder:");
            int seconds = int.Parse(Console.ReadLine()) + minutes;
            if (seconds >= 165 && seconds <= 260)
            {
                Console.WriteLine("Låten är godkänd för att spelas i radion.");
            }
            else if (seconds < 165)
            {
                Console.WriteLine("Låten är för kort för att spelas i radion.");
            }
            else
            {
                Console.WriteLine("Låten är för lång för att spelas i radion.");
            }
        }
    }
}