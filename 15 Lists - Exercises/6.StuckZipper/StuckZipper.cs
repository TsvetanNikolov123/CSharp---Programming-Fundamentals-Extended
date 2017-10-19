namespace _6.StuckZipper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StuckZipper
    {
        public static void Main()
        {
            List<int> firstList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int minLenght = FindMinLenghtNumber(firstList, secondList);

            List<int> firstFilteredList = new List<int>();
            List<int> secondFilteredList = new List<int>();

            for (int i = 0; i < firstList.Count; i++)
            {
                if (FindNumberLength(firstList[i]) <= minLenght)
                {
                    firstFilteredList.Add(firstList[i]);
                }
            }

            for (int i = 0; i < secondList.Count; i++)
            {
                if (FindNumberLength(secondList[i]) <= minLenght)
                {
                    secondFilteredList.Add(secondList[i]);
                }
            }

            List<int> result = new List<int>();
            for (int i = 0; i < Math.Max(firstFilteredList.Count, secondFilteredList.Count); i++)
            {
                if (i < secondFilteredList.Count)
                {
                    result.Add(secondFilteredList[i]);
                }

                if (i < firstFilteredList.Count)
                {
                    result.Add(firstFilteredList[i]);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }

        private static int FindMinLenghtNumber(List<int> firstList, List<int> secondList)
        {
            int minLength = int.MaxValue;

            for (int i = 0; i < firstList.Count; i++)
            {
                if (minLength > FindNumberLength(firstList[i]))
                {
                    minLength = FindNumberLength(firstList[i]);
                }
            }

            for (int i = 0; i < secondList.Count; i++)
            {
                if (minLength > FindNumberLength(secondList[i]))
                {
                    minLength = FindNumberLength(secondList[i]);
                }
            }
            return minLength;
        }

        private static int FindNumberLength(int number)
        {
            int digitCount = 0;
            number = Math.Abs(number);
            while (number > 0)
            {
                digitCount++;
                number /= 10;
            }
            return digitCount;
        }
    }
}
