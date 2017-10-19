namespace _4.SortArrayUsingBubbleSort
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BubbleSortProgram
    {
        public static void Main()
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            //Swap(ref arr[0], ref arr[1]);
            BubbleSort(arr);

            Console.WriteLine(string.Join(" ",arr));
        }

        public static void BubbleSort(int[] arr)
        {
            while (true)
            {
                bool swapped = false;
                for (int index = 0; index < arr.Length - 1; index++)
                {
                    // тук проверяваме дали първия елемент е по голям от втория... index  и index + 1;
                    // и ако първия е по голям от втория да ги размени
                    if (arr[index] > arr[index + 1])
                    {
                        Swap(ref arr[index], ref arr[index + 1]);
                        swapped = true;
                    }
                }

                if (!swapped)
                {
                    break;
                }
            }
        }
        // Тук подаваме елементите по референция - това значи че няма да копира елементите от масива
        // и след това да работиме с тях(стойностни данни), а ще работиме директно с елементите от масива !!!
        //                      ref
        public static void Swap(ref int first, ref int second)
        {
            int temp = first;
            first = second;
            second = temp;
        }
    }
}
