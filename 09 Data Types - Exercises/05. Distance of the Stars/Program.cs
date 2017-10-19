using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Distance_of_the_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal toNearestStar = 4.22m * 9450000000000m;
            decimal toCenterOfGalaxy = 26000m * 9450000000000m;
            decimal diameterMilkyWay = 100000m * 9450000000000m;
            decimal distanceEdge = 46500000000m * 9450000000000m;

            Console.WriteLine(toNearestStar.ToString("e2"));
            Console.WriteLine(toCenterOfGalaxy.ToString("e2"));
            Console.WriteLine(diameterMilkyWay.ToString("e2"));
            Console.WriteLine(distanceEdge.ToString("e2"));
        }
    }
}
