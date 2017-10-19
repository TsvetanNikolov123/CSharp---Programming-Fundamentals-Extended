using System;

namespace _03.Smallest_Element_in_Array
{
    class SmallestElementInArray
    {
        static void Main()
        {
            string[] stringArr = Console.ReadLine().Split();
            int[] arr = new int[stringArr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(stringArr[i]);
            }

            int smallest = int.MaxValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < smallest)
                {
                    smallest = arr[i];
                }
            }
            Console.WriteLine(smallest);
        }
    }
}
