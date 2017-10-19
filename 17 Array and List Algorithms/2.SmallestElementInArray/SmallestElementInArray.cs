namespace _2.SmallestElementInArray
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class SmallestElementInArray
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int smallestInt = int.MaxValue;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < smallestInt)
                {
                    smallestInt = numbers[i];
                }
            }
            Console.WriteLine(smallestInt);
        }
    }
}
