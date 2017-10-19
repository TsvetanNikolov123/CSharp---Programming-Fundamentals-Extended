using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Training_Hall_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            int numberToBuy = int.Parse(Console.ReadLine());

            double spend = 0;

            for (int i = 1; i <= numberToBuy; i++)
            {

                string itemName = Console.ReadLine();
                double itemPrice = double.Parse(Console.ReadLine());
                int itemCount = int.Parse(Console.ReadLine());

                if (itemCount > 1)
                {
                    if (itemName.EndsWith("y"))
                    {
                        itemName = itemName.Remove(itemName.Length - 1);

                        itemName += "ies";
                    }
                    else if (itemName.EndsWith("o") ||
                        itemName.EndsWith("ch") ||
                        itemName.EndsWith("s") ||
                        itemName.EndsWith("sh") ||
                        itemName.EndsWith("x") ||
                        itemName.EndsWith("z"))
                    {
                        itemName += "es";
                    }
                    else
                    {
                        itemName += "s";
                    }

                    Console.WriteLine($"Adding {itemCount} {itemName} to cart.");
                }
                else
                {
                    Console.WriteLine($"Adding 1 {itemName} to cart.");
                }
                spend += itemPrice * itemCount;
                if (spend > budget)
                {
                    Console.WriteLine("Subtotal: ${0:F2}", spend);
                    Console.WriteLine("Not enough. We need ${0:f2} more.", spend - budget);
                    return;
                }
            }
            Console.WriteLine("Subtotal: ${0:F2}", spend);
            Console.WriteLine("Money left: ${0:f2}", budget - spend);
        }
    }
}
