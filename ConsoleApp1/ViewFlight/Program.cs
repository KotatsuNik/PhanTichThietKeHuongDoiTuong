using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewFlight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Title = "Flight Management Application";
            Console.Write("Edit flights MODE\t\t\t\t\t\t\t\t");
            Console.Write("Flight Code = ?\t\t\t\t\t\t\t\t\t");
            Console.Write("Departure airport code = MLS\t\t\t\t\t\t\t");
            Console.Write("Arrived airport code = SGN\t\t\t\t\t\t\t");
            Console.Write("Flight date = 16 Mar 2018\t\t\t\t\t\t\t");
            Console.Write("----------------------------SELECT FLIGHT TO EDIT-------------------------------");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("No.    |Flight code    |Dep.    |Arr.    |Date          |");
            Console.WriteLine("=========================================================");
            Console.WriteLine("01     |MH125          |MLS     |SGN     |16 Mar 2018   |");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("02     |AA355          |MLS     |SGN     |16 Mar 2018   |");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("03     |VN167          |MLS     |SGN     |16 Mar 2018   |");
            Console.WriteLine("ADD NEW                                                  ");
            Console.WriteLine("DESELECT                                                 ");
            Console.WriteLine("=========================================================");
            Console.WriteLine("Page 1/1 <- ->  | Selection: 02 | Press Enter to select |");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write("----------------------------CHANGE FLIGHT INFOMATION----------------------------");

            Console.Write("Flight Code (AA355)= VN254\t\t\t\t\t\t\t");
            Console.Write("Departure airport code (MLS)= UNCHANGED\t\t\t\t\t\t");
            Console.Write("Arrived airport code (SGN)= UNCHANGED\t\t\t\t\t\t");
            Console.Write("Flight date (16 Mar 2018)= 20 Apr 2018\t\t\t\t\t\t");
            Console.Write("Do you want to change: ->");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("YES");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write("\t\tNO\t\t\t\t\t");
            Console.ReadLine();
        }
    }
}
