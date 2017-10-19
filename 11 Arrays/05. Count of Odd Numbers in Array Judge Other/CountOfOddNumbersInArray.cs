using System;
using System.Linq;

namespace _05.Count_of_Odd_Numbers_in_Array_Judge_Other
{
    class CountOfOddNumbersInArray
    {
        static void Main()
        {
            int[] arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int oddElementsCount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    oddElementsCount++;
                }
            }
            Console.WriteLine(oddElementsCount);
        }
    }
}
