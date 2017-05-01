using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOpg1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv dit navn");
            String Navn = Console.ReadLine();
            String StortNavn = Navn.ToUpper();
            Console.WriteLine("Dit navn er " + StortNavn);
            Console.ReadKey();
        }
    }
}
