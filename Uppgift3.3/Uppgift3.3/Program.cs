using System;
namespace Uppgift3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många timmar vill du hyra bilen?");
            int timmar = int.Parse(Console.ReadLine());
            int kostnad = timmar * 80;
            if (kostnad > 950)
            {
                Console.WriteLine("Kostnaden överskrider 950 kr. Du får hyra bilen i max 11 timmar");
            }
            else
            {
                Console.WriteLine($"Kostnaden för att hyra bilen i {timmar} timmar är {kostnad} kr."); 
            }
        }
    }
}