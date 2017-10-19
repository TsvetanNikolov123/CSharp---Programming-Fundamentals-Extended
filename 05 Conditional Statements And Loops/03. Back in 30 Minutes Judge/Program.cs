using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Back_in_30_Minutes_Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            int houers = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes += 30;

            houers += (minutes / 60);
            minutes = minutes % 60;

            //     if (houers >= 24)
            //     {
            //         houers = 0;
            //     }

            houers = houers >= 24 ? 0 : houers;

            Console.WriteLine($"{houers}:{minutes:d2}");
        }
    }
}
