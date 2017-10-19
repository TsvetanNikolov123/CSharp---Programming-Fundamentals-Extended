using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.DNA_Sequences
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <=4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    for (int k = 1; k <= 4; k++)
                    {
                        if (i + j + k >= n)
                        {
                            Console.Write('O');
                            if (i == 1)
                            {
                                Console.Write('A');
                            }
                            else if (i == 2)
                            {
                                Console.Write('C');
                            }
                            else if (i == 3)
                            {
                                Console.Write('G');
                            }
                            else if (i == 5)
                            {
                                Console.Write('T');
                            }
                            Console.Write('O');
                        }
                        else
                        {
                            Console.Write('X');

                            Console.Write('X');
                        }
                    }
                }
            }
        }
    }
}
