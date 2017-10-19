using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Draw_a_Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintTopRow(n);
            PrintMiddleRow(n);
            PrintBottomRow(n);
        }

        static void PrintMiddleRow(int n)
        {
            for (int j = 0; j < n - 2; j++)
            {
                Console.Write('-');
                for (int i = 1; i < n; i++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine('-');
            }
            
        }

        static void PrintTopRow(int n)
        {
            Console.WriteLine(new string('-', n * 2));
        }
        static void PrintBottomRow(int n)
        {
            Console.WriteLine(new string('-', n * 2));
        }


    }
}
