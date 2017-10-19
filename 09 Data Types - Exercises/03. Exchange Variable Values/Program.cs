using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int oldA = a;
            int oldB = b;

            a = oldB;
            b = oldA;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
