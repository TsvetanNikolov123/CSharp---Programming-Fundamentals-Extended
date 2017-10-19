using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Tricky_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string delimiter = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string input = "";

            for (int i = 1; i <= n; i++)
            {
                input += input = Console.ReadLine();
                if (i == n)
                {
                    break;
                }
                else
                {
                    input += delimiter;
                }
            }
            Console.WriteLine(input);
        }
    }
}
