using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Back_in_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int houers = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            
            if (minutes + 30 >= 60)
            {
                houers++;
                minutes += 30;
                minutes = minutes - 60;
                if (houers >= 24)
                {
                    houers -= 24;
                }
                Console.WriteLine("{0}:{1:d2}", houers, minutes);
            }
            else
            {
                minutes += 30;
                Console.WriteLine("{0}:{1:d2}", houers, minutes);
            }

        }
    }
}
