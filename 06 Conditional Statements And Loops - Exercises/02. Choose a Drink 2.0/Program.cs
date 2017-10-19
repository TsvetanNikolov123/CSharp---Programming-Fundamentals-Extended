using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Choose_a_Drink_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());


            switch (profession)
            {
                case "Athlete":
                    Console.WriteLine($"The Athlete has to pay {quantity * 0.7:f2}.");
                    break;
                case "Businessman":
                    Console.WriteLine($"The Businessman has to pay {quantity * 1.00:f2}.");
                    break;
                case "Businesswoman":
                    Console.WriteLine($"The Businesswoman has to pay {quantity * 1.00:f2}.");
                    break;
                case "SoftUni Student":
                    Console.WriteLine($"The SoftUni Student has to pay {quantity * 1.70:f2}.");
                    break;
                default:
                    Console.WriteLine($"The {profession} has to pay {quantity * 1.20:f2}.");
                    break;
            }
        }
    }
}
