using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.X
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int middleEmpty = n - 2;
            int counter = 0;
            for (int i = 1; i <= n / 2; i++)
            {
                Console.WriteLine("{0}x{1}x",
                    new string(' ', counter),
                    new string(' ', middleEmpty));
                counter++;
                middleEmpty -= 2;
            }

            Console.WriteLine("{0}x",
                new string(' ', n / 2));

            int lowerLeftEmpty = n / 2 - 1;
            int lowerMiddleEmpty = 1;
            for (int i = 1; i <= n / 2; i++)
            {
                Console.WriteLine("{0}x{1}x",
                    new string(' ', lowerLeftEmpty),
                    new string(' ', lowerMiddleEmpty));
                lowerLeftEmpty--;
                lowerMiddleEmpty += 2;
            }
        }
    }
}
