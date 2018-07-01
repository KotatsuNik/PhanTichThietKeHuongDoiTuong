using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Title = "Flight Management Application";
            Console.Write("\t\t\tFlight Management Application\t\t\t\t");
            Console.Write("Please select function\t\t\t\t\t\t\t\t");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("\t-> View flights\t\t\t\t\t\t\t\t");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write("\tEdit flight data\t\t\t\t\t\t\t");
            Console.Write("\tView passager and flight attendance information\t\t\t\t");
            Console.Write("\tView package stored in flight\t\t\t\t\t\t");

            Console.ReadLine();
            
        }
    }
}
