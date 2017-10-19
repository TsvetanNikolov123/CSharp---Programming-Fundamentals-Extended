using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.X_Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int row = 0; row < num; row++)
            {
                for (int col = 0; col < num; col++)
                {
                    if (col == row)
                    {
                        Console.Write('X');
                    }
                    else if (col == num - row - 1)
                    {
                        Console.Write('X');
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
