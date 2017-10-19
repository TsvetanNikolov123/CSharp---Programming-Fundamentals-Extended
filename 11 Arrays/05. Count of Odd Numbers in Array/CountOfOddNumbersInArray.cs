using System;
using System.Linq;

namespace _05.Count_of_Odd_Numbers_in_Array
{
    class CountOfOddNumbersInArray
    {
        static void Main()
        {
            int odd = 0;
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray(); ;

            foreach (int i in numbers)
            {
                if (i % 2 != 0)
                {
                    odd++;
                }
            }
            Console.WriteLine("{0}", odd);
        }
    }
}
