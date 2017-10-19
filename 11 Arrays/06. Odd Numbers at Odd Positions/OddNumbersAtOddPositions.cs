using System;
using System.Linq;

namespace _06.Odd_Numbers_at_Odd_Positions
{
    class OddNumbersAtOddPositions
    {
        static void Main()
        {
            int[] arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0 && i % 2 != 0)
                {
                    Console.WriteLine("Index {0} -> {1}", i, arr[i]);
                }
            }
        }
    }
}
