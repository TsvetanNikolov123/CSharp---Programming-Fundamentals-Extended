namespace _5.SortArrayUsingInsertionSort
{
    using System;
    using System.Linq;

    public class InsertionSortProgram
    {
        public static void Main()
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            InsertionSort(arr);

            Console.WriteLine(string.Join(" ", arr));
        }

        public static void InsertionSort(int[] arr)
        {
            for (int firstIndex = 0; firstIndex < arr.Length; firstIndex++)
            {
                for (int secondIndex = firstIndex; secondIndex > 0; secondIndex--)
                {
                    if (arr[secondIndex - 1] > arr[secondIndex])
                    {
                        Swap(ref arr[secondIndex - 1], ref arr[secondIndex]);
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        public static void Swap(ref int first, ref int second)
        {
            int temp = first;
            first = second;
            second = temp;
        }
    }
}
