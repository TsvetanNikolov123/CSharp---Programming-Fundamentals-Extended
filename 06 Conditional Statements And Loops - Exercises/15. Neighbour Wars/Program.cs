using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            int peshoDmg = int.Parse(Console.ReadLine());
            int goshoDmg = int.Parse(Console.ReadLine());

            int peshoHealth = 100;
            int goshoHealth = 100;

            int counter = 0;

            while (true)            //peshoHealth > 0 || goshoHealth > 0
            {
                counter++;

                if (counter % 2 != 0) // Pesho attacks with “Roundhouse kick” odd turn
                {
                    goshoHealth -= peshoDmg;
                    
                    if (goshoHealth <= 0)
                    {
                        Console.WriteLine("Pesho won in {0}th round.", counter);
                        return;
                    }
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth} health.");
                }
                else                   // Gosho attacks with “Thunderous fist” even turn     
                {
                    peshoHealth -= goshoDmg;
                    
                    if (peshoHealth <= 0)
                    {
                        Console.WriteLine("Gosho won in {0}th round.", counter);
                        return;
                    }
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealth} health.");
                }

                if (counter % 3 == 0)
                {
                    peshoHealth += 10;
                    goshoHealth += 10;
                }
            }
        }
    }
}
