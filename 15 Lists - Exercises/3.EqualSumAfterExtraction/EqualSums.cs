namespace _3.EqualSumAfterExtraction
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class EqualSums
    {
        public static void Main()
        {
            List<int> firstList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> filteredSecondList = new List<int>();

            for (int i = 0; i < firstList.Count; i++)
            {
                for (int j = 0; j < secondList.Count; j++)
                {
                    if (firstList[i] == secondList[j])
                    {
                        secondList.RemoveAt(j);
                        j--;
                    }
                }
            }

            long sumSecondList = secondList.Sum();
            long sumFirstList = 0L;

            foreach (int number in firstList)
            {
                sumFirstList += number;
            }

            if (sumFirstList == sumSecondList)
            {
                Console.WriteLine("Yes. Sum: " + sumSecondList);
            }
            else
            {
                Console.WriteLine("No. Diff: " + Math.Abs(sumSecondList - sumFirstList));
            }
        }
    }
}
