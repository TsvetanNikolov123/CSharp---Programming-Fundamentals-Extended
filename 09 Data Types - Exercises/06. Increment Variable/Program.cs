using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Increment_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int overflows = 0;
            byte number = 0;

            for (int i = 0; i < n; i++)
            {
                number++;

                if (number == 0)


                    overflows++;
            }
            Console.WriteLine(number);

            if (overflows > 0)
            {
                Console.WriteLine("Overflowed " + overflows + " times");
            }



            /*
            int OverflowedTimes = n / 255;
            int rest = n % 255;
            
            Console.WriteLine(rest - OverflowedTimes);
            if (OverflowedTimes != 0)
            {
                Console.WriteLine("Overflowed {0} times", OverflowedTimes);
            }
            */
        }
    }
}
