using System;

namespace _01.Sum_Array_Elements
{
    class SumArrayElements
    {
        static void Main()
        {
            int numberOfElements = int.Parse(Console.ReadLine());

            var array = new int[numberOfElements];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            var sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            Console.WriteLine(sum);
        }
    }
}
