namespace _2.BinarySearch
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BinarySearchProgram
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int numberToFind = int.Parse(Console.ReadLine());

            int countLinearSearch = LinearSearch(numbers, numberToFind);
            int binarySearchCount = BinarySearch(numbers, numberToFind);

            numbers.Sort();

            if (numbers.Contains(numberToFind))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }


            Console.WriteLine($"Linear search made {countLinearSearch} iterations");
            Console.WriteLine($"Binary search made {binarySearchCount} iterations");
        }

        public static int BinarySearch(List<int> numbers, int numbersToFind)
        {
            numbers.Sort();
            int min = 0;
            int max = numbers.Count - 1;
            int count = 0;

            while (min <= max)
            {
                int midPoint = (min + max) / 2;
                count++;
                if (numbers[midPoint] < numbersToFind)
                {
                    min = midPoint + 1;
                }

                if (numbers[midPoint] > numbersToFind)
                {
                    max = midPoint - 1;
                }

                if (numbers[midPoint] == numbersToFind)
                {
                    break;
                }
            }
            return count;
        }

        public static int LinearSearch(List<int> numbers, int numberToFind)
        {
            int count = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                count++;
                if (numbers[i] == numberToFind)
                {
                    return count;
                }
            }

            return count;
        }
    }
}