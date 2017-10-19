using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int oddNums = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= oddNums; i++)
            {
                Console.WriteLine("{0}", 2 * i - 1);
                sum += 2 * i - 1;
            }
            Console.WriteLine("Sum: {0}", sum);
        }
    }
}
