using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Debugging_Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Math.Abs(int.Parse(Console.ReadLine()));
            Console.WriteLine(GetMultipleOfEvensAndOddsDigits(n));
        }

        private static int GetMultipleOfEvensAndOddsDigits(int n)
        {
            int sumEvent = GetMultipleOfEvensDigits(n);
            int sumOdds = GetMultipleOfOddsDigits(n);
            return sumEvent * sumOdds;
        }

        private static int GetMultipleOfEvensDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }
                n /= 10;
            }
            return sum;
        }

        private static int GetMultipleOfOddsDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }
                n /= 10;
            }
            return sum;
        }
    }
}
