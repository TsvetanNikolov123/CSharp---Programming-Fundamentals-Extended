using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.X_Judge_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int left = 0;
            int right = num - 1;

            for (int row = 0; row < num; row++)
            {
                for (int col = 0; col < num; col++)
                {
                    if (col == left || col == right)
                    {
                        Console.Write('X');
                    }                    
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
                left++;
                right--;
            }
        }
    }
}
