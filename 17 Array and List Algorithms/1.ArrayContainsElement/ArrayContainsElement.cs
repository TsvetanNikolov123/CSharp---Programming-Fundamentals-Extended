namespace _1.ArrayContainsElement
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ArrayContainsElement
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());

            bool isFound = false;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == n)
                {
                    isFound = true;
                }
            }

            if (!isFound)
            {
                Console.WriteLine("no");
            }
            else
            {
                Console.WriteLine("yes");
            }
        }
    }
}
