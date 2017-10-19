using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Vapor_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentBalance = double.Parse(Console.ReadLine());
            string game = string.Empty;
            double spendMoney = 0.0;

            while (game != "Game Time")
            {
                game = Console.ReadLine();

                switch (game)
                {
                    case "Game Time":                        
                        break;
                    case "OutFall 4":
                        if (spendMoney + 39.99 > currentBalance)
                        {
                            Console.WriteLine("Too Expensive");
                            break;
                        }
                        spendMoney += 39.99;
                        Console.WriteLine("Bought OutFall 4");
                        break;
                    case "CS: OG":
                        if (spendMoney + 15.99 > currentBalance)
                        {
                            Console.WriteLine("Too Expensive");
                            break;
                        }
                        spendMoney += 15.99;
                        Console.WriteLine("Bought CS: OG");
                        break;
                    case "Zplinter Zell":
                        if (spendMoney + 19.99 > currentBalance)
                        {
                            Console.WriteLine("Too Expensive");
                            break;
                        }
                        spendMoney += 19.99;
                        Console.WriteLine("Bought Zplinter Zell");
                        break;
                    case "Honored 2":
                        if (spendMoney + 59.99 > currentBalance)
                        {
                            Console.WriteLine("Too Expensive");
                            break;
                        }
                        spendMoney += 59.99;
                        Console.WriteLine("Bought Honored 2");
                        break;
                    case "RoverWatch":
                        if (spendMoney + 29.99 > currentBalance)
                        {
                            Console.WriteLine("Too Expensive");
                            break;
                        }
                        spendMoney += 29.99;
                        Console.WriteLine("Bought RoverWatch");
                        break;
                    case "RoverWatch Origins Edition":
                        if (spendMoney + 39.99 > currentBalance)
                        {
                            Console.WriteLine("Too Expensive");
                            break;
                        }
                        spendMoney += 39.99;
                        Console.WriteLine("Bought RoverWatch Origins Edition");
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        break;
                }
                if (spendMoney >= currentBalance )
                {
                    Console.WriteLine("Out of money!");
                    break;
                }
            }
            if (spendMoney >= currentBalance)
            {
                return;
            }
            else
            {
                Console.WriteLine($"Total spent: ${spendMoney:f2}. Remaining: ${currentBalance - spendMoney:f2}");
            }
            
        }
    }
}
