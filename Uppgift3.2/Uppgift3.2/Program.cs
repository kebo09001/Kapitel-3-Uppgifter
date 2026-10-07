using System;
namespace Uppgift3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Har du gått ut gymnasiet? J/N");
            string svar = Console.ReadLine();
            Console.WriteLine("Hur gammal är du?");
            int svar2 = int.Parse(Console.ReadLine());
            if(svar.ToLower() == "j" && svar2 < 22)
            {
                Console.WriteLine("Vi vill gärna anställa dig!");
            }
            else
            {
                Console.WriteLine("Vi letar tyvärr efter annan personal just nu.");
            }
        }
    }
}