namespace _4.FlipListSides
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FlipListSides
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int middleOfList = numbers.Count() / 2;

            for (int i = 1; i < middleOfList; i++)
            {
                int temp = numbers[i];
                numbers[i] = numbers[(numbers.Count - 1) - i];
                numbers[(numbers.Count - 1) - i] = temp;
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
