using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("BENVENUTO IN BUDDYBANK");
            Console.WriteLine("\n");
            Console.WriteLine("Hai gia un account?  y/n");
            string resp = Console.ReadLine();
            if(resp == "y")
            { 
            ContoCorrente nuovoUtente = new ContoCorrente("Antonio", "Marucci", 0, true);
            nuovoUtente.StartMenu();
            }
            else 
            { 

            ContoCorrente secondoUtente = new ContoCorrente();
            secondoUtente.StartMenu();
            }
        }
    }
}
