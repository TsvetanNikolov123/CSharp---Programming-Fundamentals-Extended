using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.ASCII_String
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string word = "";
            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                char fromNum = (char)num;
                word += fromNum;
            }
            Console.WriteLine(word);
        }
    }
}
